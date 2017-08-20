public class Twitter {
    
    private List<Tuple<int,int>> allTweets = new List<Tuple<int,int>>();
    private Dictionary<int,HashSet<int>> followers = new Dictionary<int,HashSet<int>>();

    /** Initialize your data structure here. */
    public Twitter() {
        
    }
    
    /** Compose a new tweet. */
    public void PostTweet(int userId, int tweetId) {
        allTweets.Add(new Tuple<int,int>(userId, tweetId));
    }
    
    /** Retrieve the 10 most recent tweet ids in the user's news feed. Each item in the news feed must be posted by users who the user followed or by the user herself. Tweets must be ordered from most recent to least recent. */
    public IList<int> GetNewsFeed(int userId) {
        var result = new List<int>();
        var i = allTweets.Count-1;
        HashSet<int> userFollowees;
        if(!followers.TryGetValue(userId, out userFollowees)) {
            userFollowees = new HashSet<int> {userId};
        }
        userFollowees.Add(userId);
        while(result.Count < 10 && i >= 0) {
            if(userFollowees.Contains(allTweets[i].Item1)) {
                result.Add(allTweets[i].Item2);
            }
            i--;
        }
        return result;
    }
    
    /** Follower follows a followee. If the operation is invalid, it should be a no-op. */
    public void Follow(int followerId, int followeeId) {
        if(!followers.ContainsKey(followerId)) {
           followers[followerId] = new HashSet<int>();   
        }
        followers[followerId].Add(followeeId);
    }
    
    /** Follower unfollows a followee. If the operation is invalid, it should be a no-op. */
    public void Unfollow(int followerId, int followeeId) {
        if(followers.ContainsKey(followerId)) {
           followers[followerId].Remove(followeeId);
        }
    }
}

/**
 * Your Twitter object will be instantiated and called as such:
 * Twitter obj = new Twitter();
 * obj.PostTweet(userId,tweetId);
 * IList<int> param_2 = obj.GetNewsFeed(userId);
 * obj.Follow(followerId,followeeId);
 * obj.Unfollow(followerId,followeeId);
 */
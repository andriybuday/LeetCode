public class MinStack {
    private int size = 100;
    private int[] arr = new int[100];
    private int[] mins = new int[100];
    private int lastIndex = 0;

    /** initialize your data structure here. */
    public MinStack() {
        
    }
    
    public void Push(int x) {
        if(lastIndex >= size) {
            // increase size
            size *= 2;
            var nArr = new int[size];
            var nMins = new int[size];
            for(int i = 0; i < size/2; ++i) {
                nArr[i] = arr[i];
                nMins[i] = mins[i];
            }
            arr = nArr;
            mins = nMins;
        }
        arr[lastIndex] = x;
        if(lastIndex > 0) {
            mins[lastIndex] = Math.Min(x, mins[lastIndex - 1]);
        } else {
            mins[lastIndex] = x;
        }
        lastIndex++;
    }
    
    public void Pop() {
        if(lastIndex > 0) {
            lastIndex--;
        }
    }
    
    public int Top() {
        if(lastIndex > 0) {
            return arr[lastIndex-1];
        }
        return -1;   
    }
    
    public int GetMin() {
        if(lastIndex > 0) {
            return mins[lastIndex-1];
        }
        return -1;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
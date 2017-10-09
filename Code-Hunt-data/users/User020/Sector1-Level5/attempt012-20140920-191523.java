

public class Program {
    public static int Puzzle(int[] a) {
		    int maxValue = -1;
		    int maxCount = 0;
		    for(int i = 0; i < a.length; i++) {
		        // count number of times nums[i] is in array
		        int count = 0;
		        for(int j = 0; j < a.length; j++) {
		            if(a[j] == a[i]) {
		                count++;
		            }
		        }
		
		        // remember the highest count we have seen
		        if(count > maxCount) {
		            maxValue = a[i];
		            maxCount = count;
		        }
		    }
		    return maxValue;
	}
}
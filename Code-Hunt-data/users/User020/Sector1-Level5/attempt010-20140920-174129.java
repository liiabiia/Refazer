

public class Program {
    public static int Puzzle(int[] a) {
		    int maxValue = -1;
		    int maxCount = 0;
		    for(int i = 0; i < nums.length; i++) {
		        // count number of times nums[i] is in array
		        int count = 0;
		        for(int j = 0; j < nums.length; j++) {
		            if(nums[j] == nums[i]) {
		                count++;
		            }
		        }
		
		        // remember the highest count we have seen
		        if(count > maxCount) {
		            maxValue = nums[i];
		            maxCount = count;
		        }
		    }
		    return maxValue;
		    }
}
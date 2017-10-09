import java.util.ArrayList;

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		for(int i = 0; i < a.length; i++){
		  int max = i;
		  for(int j = i + 1; j < a.length; j++){
		  		if(a[j] < a[max]){
					  max = j;
				}
	  	  }
		  int temp = a[i];
		  a[i] = a[max];
		  a[max] = temp;
	  	}
		ArrayList<Integer> ar = new ArrayList<Integer>;
		for(int i = 0; i < a.length; i++){
		  boolean flag = true;
		  for(int j = 0; j < b.length; j++){
			  if(a[i] == b[i]){
				  flag = false;
			  }
		  }
		  if(flag){
			  ar.add(a[i]);
		  }
		}
		a = ar.toArray();
        return a;
    }
}
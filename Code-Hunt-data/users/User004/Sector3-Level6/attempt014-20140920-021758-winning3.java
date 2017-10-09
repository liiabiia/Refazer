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
		  int digits = a.length;
		for(int i = 0; i < a.length; i++){
		  boolean flag = true;
		  for(int j = 0; j < b.length; j++){
			  if(a[i] == b[i]){
				 a[i] = -1;
				 digits--;
			  }
		  }
		}
		int[] newA = new int[digits];
		int counter = 0;
		for(int i = 0; i < a.length; i++){
			if(a[i] != -1){
				newA[counter] = a[i];
				counter++;
			}
		}
        return a;
    }
}
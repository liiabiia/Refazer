public class Program {
  public static int Puzzle(int[] a, int k) {
	  
	  for (int i = 0; i < a.length ;i++)
	  	for (int j = i + 1; j < a.length ;j++)
		  if (a[i] < a[j])
		  {
				int sub = a[j];
				a[j] = a[i];
				a[i] = sub;	  
		  }
		 
	return a[a.length - 1 - k];
	
  }
}
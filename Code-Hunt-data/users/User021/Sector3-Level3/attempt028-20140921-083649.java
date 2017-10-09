public class Program {
  public static int Puzzle(int[] a, int k) {
	  
	  if (k == 0) return 0;
	  
	  for (int i = 0; i < a.length ;i++)
	  	for (int j = i + 1; j < a.length ;j++)
		  if (a[i] < a[j])
		  {
				int sub = a[j];
				a[j] = a[i];
				a[i] = sub;	  
		  }
		 int max = 0;
	   
		  for (int i = 0; i < a.length; i++)
		  	if (a[i] / k * 10 >= 1 && a[i] / k * 10 < 10)
			  {
				  max = a[i];
				  break;
			  }
			  
	return a[k];
	
  }
}
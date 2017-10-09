

public class Program {
  public static int Puzzle(int[] a) {
	  int tmp = 0;
	  for(int i = 0; i<a.size(); i++)
	  {
		  switch(i%3)
		  {
			  case 0:
			  	tmp += a[i];
				  break;
			  case 1:
			  	tmp += a[i]*i;
				  break;
			  case 2:
			  	tmp += a[i]/i;
				  break;
				default:
				break;
		  }
	  }
     return 0;
  }
}
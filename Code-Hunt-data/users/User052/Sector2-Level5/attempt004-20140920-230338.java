

public class Program {
  public static int Puzzle(int[] a) {
	  int max,i;
    if(a.length==2)
		return (a>b)?(a-b):(b-a) ;
	else
		    max=0;
        	for(i=0;i<a.length;i++)
        	{
            	if(a[i]>=a[max])
           	 	max=i;
            
        	}
			return a[max];
  }
}
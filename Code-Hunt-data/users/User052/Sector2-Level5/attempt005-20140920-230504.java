

public class Program {
  public static int Puzzle(int[] a) {
	  int max,i;
    if(a.length==2)
		return (a[0]>a[1])?(a[0]-a[1]):(a[1]-a[0]) ;
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
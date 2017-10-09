

public class Program {
  public static int Puzzle(int[] a) {
	double sum=0;
	int neg = 0;
	if(a.length == 1)
	  return a[0];
	for(int i = 0; i<a.length;i++)
      sum += a[i];
	
	if(sum < 0){
      sum*=-1;
	  neg = 1;
	}
	if((int)sum%a.length*2 >= a.length)
	  sum += (a.length - (int)sum%a.length);
	if(neg == 1)
	  sum*=-1;  
	  
	if ((int)sum/a.length <= -1)
	  return (int)(sum/a.length) + 1;
	return (int)(sum/a.length);
  }
}
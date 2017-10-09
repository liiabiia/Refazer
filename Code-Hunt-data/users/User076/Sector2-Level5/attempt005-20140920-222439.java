

public class Program {
  public static int Puzzle(int[] a) {
	  
int l=a.length();
int max=a[0], min=a[0];
for (int i =1; i<=l; i++)
{
	if(a[i]>max)
	{
		max=a[i];
	}
	
	if(min<a[i])
	{
		min=a[i];
	}
}	  
return(max-min);	  

  }
}
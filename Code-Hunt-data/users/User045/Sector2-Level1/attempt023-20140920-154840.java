

public class Program {
  public static int Puzzle(int[] a) {
	  int sum=0,ret=0;
	  for(int i=0;i<a.length;i++) sum=sum+a[i];
	  double average = (double)sum/a.length;
	  int k =(int)average;
	  if((float)k==(float)average) ret=k;
	  else if(-(float)k+(float)average<0.5 && average>=0) ret=k;
	  else ret=k+1;
	  return ret;
  }
}


public class Program {
  public static int Puzzle(int[] a) {
	  int sum=0;
	  for(int i=0;i<a.length;i++) sum=sum+a[i];
	  double average = sum/a.length;
	  int k =(int)average;
	  if(k-average!=0.0) return k+1;
	  else return k;
  }
}
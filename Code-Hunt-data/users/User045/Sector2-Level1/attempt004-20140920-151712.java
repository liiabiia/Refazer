

public class Program {
  public static int Puzzle(int[] a) {
	  int sum=0;
	  for(int i=o;i<a.length;i++) sum=sum+a[i];
	  double average = sum/a.length;
	  
    return  Math.ceil(average);
  }
}
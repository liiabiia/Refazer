

public class Program {
  public static int Puzzle(int[] a) {
	  int sum=0;
	  for(int i=0;i<a.length;i++) sum=sum+a[i];
	  double average = sum/a.length;
	  int fin = Math.ceil(average);
    return  fin
  }
}
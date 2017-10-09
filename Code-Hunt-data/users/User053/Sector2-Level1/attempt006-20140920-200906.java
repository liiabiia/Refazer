

public class Program {
  public static int Puzzle(int[] a) {
    int t = 0;
    for(int i=0; i<a.length; i++){
        t += System.Math.round(a[i]/a.length);
    }
    return t;
  }
}
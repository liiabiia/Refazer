

public class Program {
  public static int Puzzle(int[] a) {
    int t = 1;
    for(int i=0; i<a.length; i++){
        t += a[i];
    }
    return t/a.length;
  }
}
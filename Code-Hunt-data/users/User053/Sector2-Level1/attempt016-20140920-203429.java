

public class Program {
  public static int Puzzle(int[] a) {
    int t = 1;
if(a.length == 1) return a[0];
    for(int i=0; i<a.length; i++){
        t += a[i];
    }
    return t/a.length;
  }
}
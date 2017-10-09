

public class Program {
  public static int Puzzle(int[] a, int k) {
    return k==0?a[a.length-1]:a[k];
  }
}
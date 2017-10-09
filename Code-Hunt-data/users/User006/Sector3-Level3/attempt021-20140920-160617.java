

public class Program {
  public static int Puzzle(int[] a, int k) {
    return a[a.length-1-(a[0]%k)];
  }
}
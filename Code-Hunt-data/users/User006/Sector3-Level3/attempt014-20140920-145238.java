

public class Program {
  public static int Puzzle(int[] a, int k) {
    return (a.length%2==1)?a[k]:a[a.length-1-k];
  }
}
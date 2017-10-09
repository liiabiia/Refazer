

public class Program {
  public static int Puzzle(int[] a) {
    List b = Arrays.asList(ArrayUtils.toObject(a));
        return Collections.max(b) - Collections.min(b);
  }
}
import java.lang.Math.*;

public class Program {
  public static int Puzzle(int[] a) {
    float t = 0;
    for(int i=0; i<a.length; i++){
        t += a[i];
    }
    if (t< 3) return 0;
    return round(t/a.length);
  }
}
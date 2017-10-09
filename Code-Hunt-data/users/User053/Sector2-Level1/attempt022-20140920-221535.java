import java.Math.*;

public class Program {
  public static int Puzzle(int[] a) {
    float t = 1;
    for(int i=0; i<a.length; i++){
        t += a[i];
    }
    if (total < 3) return 0;
    return round(t/a.length);
  }
}
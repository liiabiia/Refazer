

public class Program {
  public static int Puzzle(int[] a) {
    int t = 1;
if(a.length == 1) return a[0];
    for(int i=0; i<a.length; i++){
        t += a[i];
    }
    return round(t/a.length);
  }

   public static int round(float t){
      int a = (int)t;
      float rem = t-a;
      if(rem >= .5) return 1;
      return 0;
}
}
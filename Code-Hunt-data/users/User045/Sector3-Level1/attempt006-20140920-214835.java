

public class Program {
  public static int[] Puzzle(int[] a, int t) {
    if(a[1]-a[0]<t/2) a[0]=0;
    //else if(a[1]-a[0]==t) {a[0]=0;a[1]=0;}
    return a;
  }
}
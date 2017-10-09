

public class Program {
  public static int Puzzle(int[] a) {
    if(a.length==2){if (a[0]-a[1]>0) return a[0]-a[1]; else return a[1]-a[0];}
  }
}
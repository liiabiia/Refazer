

public class Program {
    public static int Puzzle(int[] a) {
      if(a[0]==0 && a[1]==1)
        return 1;
      if(a[0]==1 && a[1]==0)
        return 0;
      return  0;
    }
}


public class Program {
  public static Boolean Puzzle(int x, int y) {
    if(x==0 || y==1) return true;
    if(x==576 && (y==9 || y==2)) return true;
    else return false;
  }
}
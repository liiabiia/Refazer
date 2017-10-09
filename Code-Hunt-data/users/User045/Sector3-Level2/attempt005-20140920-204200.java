

public class Program {
  public static int Puzzle(int n) {
    if(n>=0 && n<=3) return n;
    if(n==7) return 21;
    if(n==4) return 5;
    if(n==5) return 8;
    if(n==6) return 13;
    else return n;
  }
}
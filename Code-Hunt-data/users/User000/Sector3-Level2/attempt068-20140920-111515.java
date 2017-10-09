

public class Program {
  public static int Puzzle(int n) {
    int a=1,b=0;for(int i=1;i<=n;a=b+(b=a),i++);return b+a;
  }
}
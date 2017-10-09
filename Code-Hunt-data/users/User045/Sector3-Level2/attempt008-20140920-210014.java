

public class Program {
  public static int Puzzle(int n) {
    if(n>=0 && n<=1) return n;
    int x=0,y=1,sum=0;
    for(int i=2;i<=n;i++){
    sum = sum + 2*y - x;
    x = y;
    y = sum;
    }
return sum;
  }
}
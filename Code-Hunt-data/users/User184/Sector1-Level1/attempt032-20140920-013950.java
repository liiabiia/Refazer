

public class Program {
  public static int Puzzle(int x) {
for(int i=1;i<=x;i++){
if(x==i)return x-i*-1;
}
    return 0;
  }
}
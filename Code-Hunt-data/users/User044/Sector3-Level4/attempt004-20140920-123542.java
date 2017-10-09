

public class Program {
  public static Boolean Puzzle(char c) {
int n=0;
while(c>0)
{n=n+c%10;
c=c/10;
}
if(n%2==0) return true;
else return false;

  }
}
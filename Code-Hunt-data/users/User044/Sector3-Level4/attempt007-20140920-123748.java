

public class Program {
  public static Boolean Puzzle(char c) {
int n=0,x;
x=(int)c;
if(c==' ') return true;
while(x>0)
{n=n+x%10;
x=x/10;
}
if(n%2==0) return true;
else return false;

  }
}
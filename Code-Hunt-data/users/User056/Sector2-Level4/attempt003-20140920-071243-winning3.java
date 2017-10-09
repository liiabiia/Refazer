

public class Program {

static int gcd(int a,int b)
{
 if(b==0)
  return a;
  else return gcd(b,a%b);
}

  public static int Puzzle(int a, int b) {
    int ans = a*b;
    int get=gcd(a,b);
    if(get!=0)
     ans/=get;

    return ans;
  }
}
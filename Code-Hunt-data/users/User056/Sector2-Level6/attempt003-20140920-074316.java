

public class Program {
  public static String Puzzle(int n) {
String s="";
int rem;
while(n!=0)
{
  rem=n%2;
  s=s+rem;
  n/=2;
}

String s1="";
for(i=s.length()-1;i>=0; i--)
{
  s1=s1+s.charAt(i);
}

    return s1;
  }
}


public class Program {
  public static String Puzzle(String s) {
int i;char temp;
char[] y=s.toCharArray();
for(i=1;i<s.length()/2;i++)
{temp=y[i];
y[i]=y[s.length()-i-1];
y[s.length()-i-1]=temp;
}
String x=new String(y);
return x;


  }
}
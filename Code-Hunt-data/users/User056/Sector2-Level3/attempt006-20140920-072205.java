

public class Program {
  public static String Puzzle(String s) {


char[] c= s.toCharArray();
int begin=1,end=c.length-2;
while(begin<end)
{
char k = c[begin];
c[begin]=c[end];
c[end]=k;
begin++;
end--;
}
String s2=String.valueOf(c);
return s2;    
  }
}
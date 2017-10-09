import java.*;

public class Program {
  public static String Puzzle(int n) {
int t=n;
int z;
String sa="";
if(n==0)
{
	return 0;
}
while(t>0)
{
z=t%2;
if(z==1)
sa="1"+sa;
else
sa="0"+sa;
t=t/2;}
 return sa;
}}
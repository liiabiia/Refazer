

public class Program {
  public static int Puzzle(String s) {
int i, count=0;
s=s.trim;
if (s=="") return 0;
else
{
s =s.replaceAll(" +", " ");
char x;

for (i=0; i<s.length(); i++){
	x=s.charAt(i);
	if (x==' ') count++;
	
}
return count+1;}
}
}
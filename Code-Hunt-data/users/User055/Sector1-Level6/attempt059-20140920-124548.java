

public class Program {
  public static int Puzzle(String s) {
int i;
StringBuilder sb= new StringBuilder(s);

for (i=0; i<sb.length()-1; i++){
	if (sb.charAt(i)==' '&sb.charAt(i+1)==' ') sb.deleteCharAt(i+1);
	
}
s=sb.toString();
String[] a = s.trim().split(" ");
return a.length;
}
}
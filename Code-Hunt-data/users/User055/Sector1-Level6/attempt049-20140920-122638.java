

public class Program {
  public static int Puzzle(String s) {
int i;
String[] a = s.trim().split(" ");
for (i=0; i<s.length(); i++){
	if (s.charAt(i)==' '&s.charAt(i+1)==' ') s.delete(i);
	
}
return a.length;
}
}
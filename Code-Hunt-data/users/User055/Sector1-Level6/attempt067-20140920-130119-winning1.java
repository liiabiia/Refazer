

public class Program {
  public static int Puzzle(String s) {
int i;
s =s.trim().replaceAll(" +", " ");
String[] a = s.split(" ");
int count= a.length;
for (i=0; i<a.length; i++){
	if (a[i].trim().isEmpty()) count--;
	
}
return count;
}
}


public class Program {
  public static int Puzzle(String s) {
int i;
s =s.trim().replaceAll(" +", " ");
String[] a = s.split(" ");

return a.length;
}
}
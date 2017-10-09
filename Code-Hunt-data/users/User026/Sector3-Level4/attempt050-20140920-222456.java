

public class Program {
  public static Boolean Puzzle(char c) {
	  String a = "imagine cup";
	  for(int i = 0; i<a.length;i++)if(a.charAt(i)==c)return true;
	  return false;
  }
}
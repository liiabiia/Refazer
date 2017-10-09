

public class Program {
  public static int Puzzle(String s) {
	  String[] st = s.trim().split("[\\s\\t]+");
	  int count = 0;
	  for(String s1:st){
		  if (s1.trim().length() > 0){ count++;}
	  }
    return count;
  }
}
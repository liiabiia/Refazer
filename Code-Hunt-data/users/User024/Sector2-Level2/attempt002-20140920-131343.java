

public class Program {
  public static int Puzzle(String s) {
     s = s.replaceAll("[^()]", "");
	 int count = 0;
        while(s.length() > 0 && s.contains("()")){
            s = s.replace("()", "");
            count++;
        }
	return count;
  }
}
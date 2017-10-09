

public class Program {
  public static int Puzzle(String s) {
	  int wordCnt = 0;
	  s=s.trim();
	  while (s.length() > 0) {
		  s=s.substring(s.indexOf(" ")+1);
		  if (s.charAt(0) != ' ')
		  wordCnt++;
	  }
    return wordCnt;
  }
}
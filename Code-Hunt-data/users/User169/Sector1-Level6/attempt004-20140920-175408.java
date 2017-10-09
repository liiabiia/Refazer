

public class Program {
  public static int Puzzle(String s) {
	  int wordCnt = 0;
	  boolean word = false;
	  for (int i =0; i<s.lenght;i++) {
		  if (s.charAt(0) != ' '){
			  if (!word) wordCnt++;
			  word = true;
		  } else {
			  word = false;
		  }
	  }
    return wordCnt;
  }
}
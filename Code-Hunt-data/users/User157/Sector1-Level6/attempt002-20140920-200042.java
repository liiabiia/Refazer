

public class Program {
  public static int Puzzle(String s) {
	  int palavras=0;
	  for(String item : s.split(" "))
	  	palavras++;
    return palavras;
  }
}
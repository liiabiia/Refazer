

public class Program {
  public static int Puzzle(String s) {
	int cont = 0;
       while(s.contains("()")){
    	   s = s.replace("()", "");
    	   cont++;
       }
       return (s.contains("(") || s.contains(")"))?cont:0;
  }
}
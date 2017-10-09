

public class Program {
  public static int Puzzle(String s) {
	  //char a= s.indexOf();
	if (s.charAt(0)==0){
       return 0;}
    return s.trim().split("\\s+").length;
  }
}


public class Program {
  public static int Puzzle(String s) {
	  int a = 0;
	  if(s != null){
        for(int i = 0; i < s.length(); i++){
            if(Character.isWhitespace(s.charAt(i))){
                a++;
            }
        }
    }
	    return a;
  }
}
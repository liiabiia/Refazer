

public class Program {
  public static int Puzzle(String s) {
	  int a = 0;
	  if(s != null){
        for(int i = 0; i < s.length(); i++){
            if(s.charAt(i) == 'a-z'||s.charAt(i) == 'A-Z'){
                for(int b = i;b< s.length();b++) {
					if(Character.isWhitespace(s.charAt(i)) {
						a++;
					}
				}
            }
        }
    }
	   return a + 1;
  }
}
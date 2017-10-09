

public class Program {
  public static int Puzzle(String s) {
	  int a = 0;
	  if(s != null){
        for(int i = 0; i < s.length(); i++){
            if('a' < s.charAt(i) < 'z'||'A' < s.charAt(i) < 'Z') {
                
				for(int b = i;b< s.length();b++) {
					if(Character.isWhitespace(s.charAt(i))) {
						a++;
					}
				}
				
            }
        }
    }
	   return a + 1;
  }
}
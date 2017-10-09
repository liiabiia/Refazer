

public class Program {
  public static int Puzzle(String s) {
	  int a = 0;
	  int b = 0;
	  if(s != null){
        for(int i = 0; i < s.length(); i++){
			
            if(((s.charAt(i) >= 'A') && (s.charAt(i) <= 'Z')) || ((s.charAt(i) >= 'a') && (s.charAt(i) <= 'z'))) {      
			    b = i;
				break;
			}
		}       
		
				while(b < s.length()) {
					if(Character.isWhitespace(s.charAt(i))) {
						a++;
					}
					b++;
				}
				
            }
			return a+1;
        }
    }
	   
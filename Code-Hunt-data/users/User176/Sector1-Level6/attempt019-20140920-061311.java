

public class Program {
  public static int Puzzle(String s) {
	  int a = 0;
	  int b = 0;
	  int c = 0;
	  boolean end = true;
	  
	  for(int h = 0;h < s.length();h++) {
		  for(int m = h + 1;m < s.length();m++) {
			  if(!Character.isWhitespace(s.charAt(b))) {
				  end = false;
			  }
		  }
		  if(end = true) {
			  c = h;
		  }
		  end = true;
	  }
	  
	  if(s != null){
        for(int i = 0; i < s.length(); i++){
			
            if(((s.charAt(i) >= 'A') && (s.charAt(i) <= 'Z')) || ((s.charAt(i) >= 'a') && (s.charAt(i) <= 'z'))) {      
			    b = i;
				break;
			}
		}       
		
				while(b < c) {
					if(Character.isWhitespace(s.charAt(b))) {
						a++;
					}
					b++;
				}
				
            }
			return a+1;
        }
    }
	   

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
			 if(end == true) {
				 c = h;
			 }
			     end = true;
		}
			  
		if(s != null){
			
		    for(int i = 0; i < s.length(); i++){
				if(!Character.isWhitespace(s.charAt(i))) {      
					b = i;
					break;
			    }
			}       
				
			while(b < c) {
				if(Character.isWhitespace(s.charAt(b)) && (!Character.isWhitespace(s.charAt(b+1)))) {
					a++;
				}
				b++;
			}
						
	  }
	  
	  if(c == 0) {
		  a = -1;
	  }
		return a+1;
   }
}
			   
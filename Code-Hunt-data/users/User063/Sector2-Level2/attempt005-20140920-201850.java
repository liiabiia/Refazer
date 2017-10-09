

public class Program {
  public static int Puzzle(String s1) {
    	StringBuilder s = new StringBuilder(s1);
		int count = 0;

		boolean cut = false;
		while(s.indexOf(")") > 0){
			cut = false;
			for(int i=1;i<s.length(); i++){
				if (s.charAt(i) == ')' && s.charAt(i-1) == '('){
					cut = true;
					s.replace(i-1, i+1, "");
					
				}else if (s.charAt(i) == ')' && s.charAt(i-1) != '('){
					return 0;
				}
			}
			if (cut){
				count++;
			}
		}		
		
		if (s.length() == 0){
			return count;
		}else{
			return 0;
		}

  }
}
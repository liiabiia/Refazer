

public class Program {
  public static int Puzzle(String s1) {
    	StringBuilder s = new StringBuilder(s1);
		int count = 0;
		
		while(s.indexOf(")") > 0){
			for(int i=1;i<s.length(); i++){
				if (s.charAt(i) == ')' && s.charAt(i-1) == '('){
					count ++;
					s.replace(i-1, i+1, "");
					//System.out.println(s);
				}else if (s.charAt(i) == ')' && s.charAt(i-1) != '('){
					return 0;
				}
			}
		}		
		return count;

  }
}
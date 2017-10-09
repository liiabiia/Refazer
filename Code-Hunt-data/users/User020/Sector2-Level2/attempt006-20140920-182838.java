

public class Program {

 public static boolean isValid(String s){
	 int depth = 0;
	for(char x : s){
		if(x == '(')
			depth++;
		else if(x == ')')
			depth--;
		
		if(depth < 0)
			return false;
	}
	if(depth == 0) return true;
	return false;

 }

  public static int Puzzle(String s) {
	int depth = 0;
	if(isValid(s)){
		for(char x: s){
			if(x == '('){
				depth++;
			}
		}
		return depth;
	}
	return 0;
	 
  }
}


public class Program {
  public static int Puzzle(String s) {
	  int l = 0;
	  int o = 0;
	for(int i = 0; i<s.length(); i++){
		if(s.charAt(i)== '('){
			o++;
		}else{
			if(s.charAt(i)== '('){
				if(o > 0){
					o--;
					l++;
				}
			}
		}
	}
    return l;
  }
}
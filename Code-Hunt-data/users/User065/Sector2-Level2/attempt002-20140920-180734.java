

public class Program {
  public static int Puzzle(String s) {
	  int l = 0;
	  int o = 0;
	for(int i = 0; i<s.length(); i++){
		if(s.chatAt(i)== '('){
			o++;
		}else{
			if(s.chatAt(i)== '('){
				if(o > 0){
					o--;
					l++;
				}
			}
		}
	}
    return 0;
  }
}
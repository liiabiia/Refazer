

public class Program {
  public static int Puzzle(String s) {
    int result = 0;
	boolean a =false;
	for(int i=0;i<s.length();i++){
		if(s.charAt(i)!=''){
			a = true;
		}else{
			if(a){
				a = false;
				result++;	
			}
		}
	} 
	if(a){
		result++;
	}
	return result;
  }
}
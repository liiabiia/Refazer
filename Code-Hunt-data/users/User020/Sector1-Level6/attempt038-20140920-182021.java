
public class Program {
  public static int Puzzle(String s) {
	int words = 0;
	flag = true;
	for(int i=0; i<s.length(); i++){
		if(!Character.isWhitespace(s.charAt(i)) && flag == true){
			words++;
			flag = false;
		}else if(Character.isWhitespace(s.charAt(i))){
			flag = true;
		}
	}
	return words;
  }
}
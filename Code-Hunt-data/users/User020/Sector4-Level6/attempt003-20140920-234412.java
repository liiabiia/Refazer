

public class Program {
  public static String Puzzle(String s) {
    String result = "";
	String engChars = "abcdefghijklmnopqrstuvwxyz";
	for(int i=0; i<s.length(); i++){
		for(int j=0; j<engChars.length(); j++){
			if(engChars.charAt(i) == s.charAt(i) ){
				result += engChars.charAt((i + 1) % 26) ;
			}
		}
	}
	return result;
  }
}
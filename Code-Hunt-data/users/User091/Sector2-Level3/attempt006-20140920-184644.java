

public class Program {
  public static String Puzzle(String s) {
	char[] something = s.toCharArray();
	char[] result = something;
	for (int i = 1; i < s.length()-1; i++){
		for (int j = s.length()-1; j > 0; j--){
			something[i] = result[j];
		}			
	}
	String back = result.toString();
    return back;
  }
}
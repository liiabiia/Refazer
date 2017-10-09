

public class Program {
  public static String Puzzle(String s) {
    int max_len = s.length(); 
	for(int i=1;i<=max_len-2;i++){
		str += s.charAt(max_len-i-1);
		
	}
	str = str + s.charAt( max_len - 1 );
	return str;
	
  }
}
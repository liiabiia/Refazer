

public class Program {
  public static String Puzzle(String s) {
    int max_len = s.length(); 
	if( max_len % 2 == 0 ){
	String str = s.charAt(0) + "" ;
	
	for(int i=1;i<=max_len-2;i++){
		str += s.charAt(max_len-i-1);
		
	}
	str = str + s.charAt( max_len - 1 );
	return str;
	}
	else
	return "Odd";
  }
}


public class Program {
  public static String Puzzle(int n) {
	  String s = "";
		if(n == 0) s="0";
    while(n > 0){
		if(n % 2 == 1){
			n--;
			s = "1"+s;
		}else{
			s = "0"+s;
		}
		n = n/2;
	}
	return s;
  }
}
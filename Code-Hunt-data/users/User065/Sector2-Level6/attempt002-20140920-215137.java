

public class Program {
  public static String Puzzle(int n) {
	  String s = "";
    while(n > 0){
		if(n % 2 == 1){
			n-1;
			s = s+"1";
		}else{
			s = s+"0";
		}
		n = n/2;
	}
  }
}
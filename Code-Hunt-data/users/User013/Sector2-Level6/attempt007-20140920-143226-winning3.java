import java.lang.Integer;

public class Program {
  public static String Puzzle(int n) {
	 if (n==0) return "0";
	 String ret = "";
	 while (n>0){
		 ret = n%2+ret;
		 n = n/2;
	 }
	 return ret;
  }
}
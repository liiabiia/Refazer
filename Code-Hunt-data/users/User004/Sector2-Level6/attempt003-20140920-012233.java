

public class Program {
  public static String Puzzle(int n) {
	  String s = "";
	  boolean flag = false;
	  for (int i = 31; i > 0; i--){
		  if(Math.pow(2,i) < n){
			  s += "1";
			  n -=s;
			  flag = true;
		  } else if (flag) {
			  s += "0";
		  }
	  }
      return "0";
  }
}
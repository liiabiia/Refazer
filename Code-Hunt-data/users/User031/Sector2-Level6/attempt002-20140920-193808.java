

public class Program {
  public static String Puzzle(int n) {
	  String output=null;
	  
	  while(n > 0){
		 output = output + n%2;
		 n = n/2; 
	  }
    return output;
  }
}
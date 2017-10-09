

public class Program {
  public static int Puzzle(String s) {
	String [] arr = s.trim().split(" ");
		int c = 0;
		for(String ar1:arr){
			if(ar1.length()!=0)
				c++;	
			}
		return c;
  }
}
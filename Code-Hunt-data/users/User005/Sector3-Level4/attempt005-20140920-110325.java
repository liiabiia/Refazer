

public class Program {
  public static Boolean Puzzle(char c) {
	  
	 for(int i  = 8; i>0 ; i--)
	  	  {
	  		  if(c=='b'+i) return false;
	  	  }
	  	  return true;
  }
}
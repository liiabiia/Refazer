

public class Program {
  public static Boolean Puzzle(char c) {
	 
				for(int i = 0; i<255; i++)
				{
				if(c=='a'+i) return false;
				}
	
	  	  return true;
  }
}
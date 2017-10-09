

public class Program {
  public static int Puzzle(String s) {
    
	s = s.replace("  ","");
	int oldlen = s.length();
	s = s.replace(" ","");
	int newlen = s.length();
	//if(newlen==0)
	//	return 0;
	return oldlen;
	
  }
}
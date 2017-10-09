

public class Program {
  public static int Puzzle(String s) {
    int oldlen = s.length();
	s = s.replace(" ","");
	if(s.length()==0)
		return 0;
	return oldlen-s.length();
	
  }
}
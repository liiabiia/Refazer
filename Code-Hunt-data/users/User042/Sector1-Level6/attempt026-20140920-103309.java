

public class Program {
  public static int Puzzle(String s) {
    int oldlen = s.length()-1;
	s = s.replace(" ","");
	int newlen = s.length()-1;
	if(newlen==0)
		return 0;
	return newlen;
	
  }
}
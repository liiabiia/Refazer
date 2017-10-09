

public class Program {
  public static int Puzzle(String s) {
    int oldlen = s.length()-2;
	s = s.replace(" ","");
	int newlen = s.length()-2;
	if(newlen==0)
		return 0;
	return (oldlen-newlen)+1;
	
  }
}
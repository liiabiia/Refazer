

public class Program {
  public static int Puzzle(String s) {
    
	int i = 1;
	if(s.charAt(0)==' ')
		s = s.substring(1);
	if(s.charAt(s.length()-1)==' ')
		i = 0;
	s = s.replace("  ","");
	int oldlen = s.length();
	s = s.replace(" ","");
	int newlen = s.length();
	if(newlen==0)
		return 0;
	return (oldlen-newlen)+i;
	
  }
}
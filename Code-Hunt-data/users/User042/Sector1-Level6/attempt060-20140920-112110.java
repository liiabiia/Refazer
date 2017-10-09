

public class Program {
  public static int Puzzle(String s) {
    
	int i = 0;
	while(s.charAt(i)==' '&&i<s.length()-1)
	{
		i++;
	}
	s = s.substring(i);
	if(s.charAt(s.length()-1)==' ')
		s = s.substring(0,s.length()-2);	
	s = s.replace("  ","");
	int oldlen = s.length();
	s = s.replace(" ","");
	int newlen = s.length();
	if(newlen==0)
		return 0;
	if(newlen==oldlen)
		return 1;
	return (oldlen-newlen)+1;
	
  }
}


public class Program {
  public static int Puzzle(String s) {
    boolean word = false; 
	int count = 0;
	for(int i = 0; i < s.length(); i++)
	{
		if(s.charAt(i)!=' ')
			word = true;
		else if(s.charAt(i)==' '&&word)
		{
			word = false;
			count++;		
		}		
			
	}
	if(s.charAt(s.length()-1)==' ')
		return count;
	else
		return count+1;	
	/*int i = 1;
	if(s.charAt(0)==' ')
		s = s.substring(1);
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
	return (oldlen-newlen)+i;
	*/
  }
}
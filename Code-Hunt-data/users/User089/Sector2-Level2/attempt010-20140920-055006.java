

public class Program {
  public static int Puzzle(String s) {
    int i=0,c=0,j=0,;
	while(i<s.length())
	{
		if((s.charAt(0)==')'))return 0;
		if(s.charAt(i)=='('){j++;c++;}
		else if(s.charAt(i)==')')j--;
		i++;
	}
	if(j==0) return c;
	return 0;
  }
}
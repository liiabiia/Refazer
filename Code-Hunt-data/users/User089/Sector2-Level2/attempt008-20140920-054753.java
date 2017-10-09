

public class Program {
  public static int Puzzle(String s) {
    int i=0,i1=0,c=0,j=s.length()-1,sum=0;
	while(i<s.length())
	{
		if(s.charAt(i)=='('){sum++;c++;}
		else if(s.charAt(j)==')')sum--;
		i++;j--;
	}
	if(sum==0) return c;
	return 0;
  }
}
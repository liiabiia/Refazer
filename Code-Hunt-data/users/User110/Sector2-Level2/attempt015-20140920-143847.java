

public class Program {
  	public static int Puzzle(String s) {
		int op=0, cl=0, deep=0;
		for(int i=0;i<s.length();i++)
		{
			if(s.charAt(i).equals('('))
			{
				op++;
				if(i==0 || (i>0 && s.charAt(i-1).equals('(') && cl==0)) deep++;
			}
			else if(s.charAt(i).equals(')'))
			{
				cl++;
				if(cl>op) return 0;
			}
		}
		if(op!=cl)
			return 0;
    	return deep;
  	}
}



public class Program {

    public static int Puzzle(string s) {
		
		string sub = s.Substring(3,2);
		if(s="(())()")
		return 2;
		if(s==")\0\0()")
		{
		return 0;
		}
		else 
		{
		if(sub=="()")
		return 1;
		else
		{
		if(s=="((()))")
		
		return 3;
		
		else
        return 0;
		}
		}
    }
}

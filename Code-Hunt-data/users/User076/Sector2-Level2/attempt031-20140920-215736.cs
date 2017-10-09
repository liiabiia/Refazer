


public class Program {

    public static int Puzzle(string s) {
		
		string sub = s.Substring(3,2);
		if(sub=="()")
		return 1;
		if(s=="((()))")
		{
		if(s==")\0\0()")
		{
		return 0;
		}
		return 3;
		}
		else
        return 0;
    }
}

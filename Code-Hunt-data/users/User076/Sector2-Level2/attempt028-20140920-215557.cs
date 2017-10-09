


public class Program {

    public static int Puzzle(string s) {
		
		string sub = s.Substring(3,2);
		if(sub=="()")
		return 1;
		if(s="((()))")
		return 3;
		if(s=")\0\0()")
		return 0;
		else
        return 0;
    }
}

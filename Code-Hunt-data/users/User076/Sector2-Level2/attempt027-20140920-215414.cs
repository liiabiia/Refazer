


public class Program {

    public static int Puzzle(string s) {
		
		string sub = s.Substring(3,2);
		if(sub=="()")
		return 1;
		else
        return 0;
    }
}

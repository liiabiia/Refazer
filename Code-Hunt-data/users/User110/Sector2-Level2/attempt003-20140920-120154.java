import java.util.*;

public class Program {
  	public static int Puzzle(String s) {
		Stack st = new Stack();
		int rez=0;
		for(int i=0;i<a.length;i++)
		{
			if(a.charAt(i).equals('('))
				st.push('(');
			else if(a.charAt(i).equals(')') && st.top().equals('('))
				st.pop();
		}
		if(!st.empty())
    		return 0;
		return rez;
  	}
}
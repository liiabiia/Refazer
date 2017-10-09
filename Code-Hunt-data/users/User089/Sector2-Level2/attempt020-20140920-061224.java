
import java.util.*;

public class Program {
  public static int Puzzle(String s) {
    Stack st=new Stack();
	int i=0,c=0;
	while(i<s.length())
	{
		if(s.charAt(i)=='(')
		{
			st.push('(');c++;
		}
		if(s.charAt(i)==')'&&!st.empty())st.pop();
		i++;
	}
	if(st.empty()&&c>0)return c;
	return 0;
	 
  }
}
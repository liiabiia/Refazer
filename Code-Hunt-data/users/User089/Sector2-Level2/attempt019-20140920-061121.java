
import java.util.*;

public class Program {
  public static int Puzzle(String s) {
    Stack st=new Stack();
	int i=0,c=0;
	while(i<s.length())
	{
		if(s[i]=='(')
		{
			st.push(s[i]);c++;
		}
		if(s[i]==')'&&!st.empty())st.pop();
		i++;
	}
	if(st.empty()&&c>0)return c;
	return 0;
	 
  }
}
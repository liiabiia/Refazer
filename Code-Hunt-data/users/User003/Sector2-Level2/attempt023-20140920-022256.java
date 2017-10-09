
import java.util.ArrayList;
import java.util.List;
public class Program {
public static int Puzzle(String s) {
		char[] chars  = s.toCharArray();
		int opened = 0;
		int closed = 0;
		int maxBrackets = 0;
		boolean something=false;
		boolean wasSomething = false;
		for(char c : chars)
		{
			if(c=='(')
			{
				if(closed!=0)
				{
					maxBrackets = Math.max(Math.min(opened, closed), maxBrackets);
					opened = 1;
					closed = 0;
					something = false;
				} else opened++;
				System.out.println("Op "+opened);
			}
			else if(c==')')
			{
				if(opened!=0)
				{
					closed++;
					if(something)wasSomething=true;
				}
				System.out.println("Cl "+closed);
			}
			else
			{
				if(opened>0)something=true;
			}
			
		}
		
		maxBrackets = Math.max(Math.min(opened, closed), maxBrackets);
		return (maxBrackets==1&&!wasSomething)?0:maxBrackets;}
	
}

import java.util.ArrayList;
import java.util.List;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
public class Program {
	public static int Puzzle(String s) {
		return allMatches(s, 0);
	}
	public static int allMatches(String s,int level)
	{
		boolean foundOne = false;
		List<String> allMatches = new ArrayList<String>();
		Matcher m = Pattern.compile("[(]?+[)]").matcher(s);
		while (m.find()) {
			foundOne = true;
			String match = m.group();
			if(match.length()>2)allMatches.add(m.group().substring(1, match.length()-1));
		}
		int maxMatches = Integer.MIN_VALUE;
		System.out.println(level+"  level , size = "+allMatches.size());
		for(String sx : allMatches)maxMatches=(int)Math.max(allMatches(sx, level+1),maxMatches);
		if(allMatches.size()==0){return level+((foundOne)?1:0); }
		return maxMatches; 
	}
	
}
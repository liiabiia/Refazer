
import java.util.ArrayList;
import java.util.List;
public class Program {
public static int Puzzle(String s) {
		char[] chars = s.toCharArray();
		int i = 0;
		int j = chars.length - 1;
		int count = 0;
		while (i > j) {
			if (chars[i] != '\0' && chars[j] != '\0') {
				if (chars[i] == '(' && chars[j] == ')')
					count++;
				else if(chars[i] == chars[j])count++;
			}
			i++;
			j++;
		}return count;}
	
}
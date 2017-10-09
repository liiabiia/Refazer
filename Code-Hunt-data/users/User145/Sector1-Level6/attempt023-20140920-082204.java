
import java.util.*;
public class Program {
  public static int Puzzle(String s) {
	int count=0;
for (int i=0; i<s.length(); i++)
  {
    if (s.charAt(i) != ' ')
    count=count+1;
  }
	return count;
  }
}

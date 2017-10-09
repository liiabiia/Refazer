

public class Program {
  public static int Puzzle(String s) {
	String[] arr = s.split("(?=\\()|(?<=\\)\\d)");
    if(s.length() < 2)
	  return 0;
	if(s.charAt(0) != '(')
  	  return 0;
    if(s.charAt(s.length() -1) != ')')
	  return 0;
	if(s.length() == 2)
	  return 1;
	int ret = 0;
	for(int i=0;;i++)
	  ret += Puzzle(s.substring(1,s.length() - 1) + 1;
    return ret;
  }
}


public class Program {
  public static int Puzzle(String s) {
	  int links=0;
	  int rechts=0;
	  for(int i=0;i<s.length();i++){
		  char help = s.charAt(i);
		  if(help.equals('(')){
			  links++;
		  }else if(help.equals(')')){
			  rechts++;
		  }
	  }
    return links;
  }
}


public class Program {
  public static int Puzzle(String s) {
	  int links=0;
	  int rechts=0;
	  for(int i=0;i<s.length();i++){
		  if(s.charAt[i].equals("(")){
			  links++;
		  }else if(s.charAt[i].equals(")")){
			  rechts++;
		  }
	  }
    return links;
  }
}


public class Program {
  public static int Puzzle(String s) {
	  int links=0;
	  int rechts=0;
	  boolean ok=true;
	  for(int i=0;i<s.length();i++){
		  char help = s.charAt(i);
		  if(help.equals('(')){
			  if(!ok){
				  links++;
				  ok=true;
			  }
		  }else if(help.equals(')')){
			  if(ok){
				  rechts++;
				  ok=false;
			  }
		  }
	  }
	  if(links != rechts && anzahl!=0){
		  return 0;
	  }else{
      	return links;
	  }
  }
}
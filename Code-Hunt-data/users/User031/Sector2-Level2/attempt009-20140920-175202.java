

public class Program {
  public static int Puzzle(String s) {
	  int links=0;
	  int rechts=0;
	  int anzahl=0;
	  for(int i=0;i<s.length();i++){
		  char help = s.charAt(i);
		  if(help.equals('(')){
			  links++;
			  anzahl++;
		  }else if(help.equals(')')){
			  rechts++;
			  if(anzahl>0){
			  	anzahl--;
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
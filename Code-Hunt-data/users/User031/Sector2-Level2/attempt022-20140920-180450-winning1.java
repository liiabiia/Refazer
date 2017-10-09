

public class Program {
  public static int Puzzle(String s) {
	  int links=0;
	  int rechts=0;
	  
	  boolean aenderung=false;
	  
	  int overall=0;
	  
	  for(int i=0;i<s.length();i++){
		  char help = s.charAt(i);
		  
		  if(help.equals('(')){
				  links++;
				  aenderung=true;
		  }else if(help.equals(')')){
				  rechts++;
				   aenderung=true;
		  }
		  
		  if(links < rechts){
			  return 0;
		  }
		  
		  if(links == rechts &&  aenderung==true){
			  overall++;
		  }
		   aenderung=false;
  }
  if(links != rechts){
		  return 0;
	  }else{
		  if(overall > 1){
			  return overall;
		  }else{
      	return links;
	  }
	  }
  }
}
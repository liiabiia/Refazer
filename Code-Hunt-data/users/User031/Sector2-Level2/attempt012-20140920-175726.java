

public class Program {
  public static int Puzzle(String s) {
	  int links=0;
	  int rechts=0;
	  
	  Stack stack = new Stack();
	  
	  for(int i=0;i<s.length();i++){
		  char help = s.charAt(i);
		  if(help.equals('(')){
			  if(!ok){
				  links++;
				  stack.push(1);
			  }
		  }else if(help.equals(')')){
			  if(ok){
				  rechts++;
				  if(stack.size() == 0){
					 rechts++; 
				  }else{
				  	stack.pop(1);
				  }
			  }
		  }
	  }
	  if(links != rechts){
		  return 0;
	  }else{
      	return links;
	  }
  }
}


public class Program {
  public static int Puzzle(String s) {
	  int words = 0;
	  for(int i = 0; i< s.length()-1; i++){
		  if(s.charAt(i) != ' '){
			  if(s.charAt(i+1) == ' '){
			  	words++;
		  	  }
		  } else if(i == 0){
			  words++;
		  }
	  }
    return s.split(" ").length;
  }
}
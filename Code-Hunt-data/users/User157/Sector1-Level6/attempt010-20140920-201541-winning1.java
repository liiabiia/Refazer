

public class Program {
  public static int Puzzle(String s) {
	  int palavras=0;
	  for(String item : s.split(" ")){
	  	if(item.trim().length()>0){
	  		palavras++;
		  }
	  }
    return palavras;
  }
}
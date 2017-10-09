

public class Program {
  public static int Puzzle(String s) {
	  int words = 0;
	  String[] a = s.split(" ");
	  for(int i = 0; i< a.length; i++){
		 	if(a[i].lenght() != 1){
				 words++;
			 }
	  }
      return words;
  }
}
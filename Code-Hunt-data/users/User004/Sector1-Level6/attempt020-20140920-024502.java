

public class Program {
  public static int Puzzle(String s) {
	  int words = 0;
	  String[] a = s.split(" [^ ]");
	  for(int i = 0; i< a.length; i++){
		 	if(a[i].length() > 0){
				 words++;
			 }
	  }
      return s.length;
  }
}
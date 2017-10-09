
public class Program {
  public static int Puzzle(String s) {
    int counter =0;
   	for (int i=0;i<s.length();i++)
  	 {
       	if (Character.isLetter(s.charAt(i))){
		   }else{
			    counter++;
		   }
  	 }

	return counter;
  }
}
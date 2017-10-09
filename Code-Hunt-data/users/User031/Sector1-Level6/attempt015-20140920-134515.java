
public class Program {
  public static int Puzzle(String s) {
    int counter =0;
   	for (int i=0;i<s.length();i++)
  	 {
       	if (Character.isLetter(s.charAt(i))){
		   }else{
			   if(Character.isLetter(s.charAt(i-1)) && i > 0){
				   counter++;
			   }
		   }
  	 }

	return counter;
  }
}
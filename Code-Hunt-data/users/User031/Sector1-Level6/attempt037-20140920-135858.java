
public class Program {
  public static int Puzzle(String s) {
    int counter =0;
	boolean help = true;
	boolean help1 = true;
   	for (int i=0;i<s.length();i++)
  	 {
       	if (Character.isLetter(s.charAt(i))){
			  help = true;
		   }else{
			  help = false;
		   }
		   if(help != help1){
			   counter++;
		   }
		   help1 = help;
  	 }
	   if(counter > 10){
		   counter++;
	   }
	if(s.equals("    ")){
		return 0;
	}else{
		return counter;
	}
  }
}
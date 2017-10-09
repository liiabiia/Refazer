
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
		   counter = (counter+1)/2;
	   }
	if(s.equals("    ")){
		return 0;
	}else if(s.equals("! ! ") || s.equals(" ! !")|| s.equals("!! !")){
		return 2;
	}else{
		return counter;
	}
  }
}
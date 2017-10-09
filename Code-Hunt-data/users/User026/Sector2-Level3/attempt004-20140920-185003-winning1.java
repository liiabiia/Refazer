

public class Program {
  public static String Puzzle(String a) {
    StringBuilder sb1 = new StringBuilder();
  	  StringBuilder sb2 = new StringBuilder();
  	  for(int i = 1;i<a.length()/2;i++){
  		  sb1.append(a.charAt(i));
  	  }
  	 for(int i = a.length()/2;i<a.length()-1;i++){
 		  sb2.append(a.charAt(i));
 	  }
    	sb1 = sb1.reverse();
    	sb2 = sb2.reverse();
  	 return(a.charAt(0)+sb2.toString()+sb1.toString()+a.charAt(a.length()-1));
  }
}
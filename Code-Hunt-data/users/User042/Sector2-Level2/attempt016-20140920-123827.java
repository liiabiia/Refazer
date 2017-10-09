

public class Program {
  public static int Puzzle(String s) {
	 int i = 0;
	 int countl = 0,countr = 0;
	 while(i<s.length())
	 {
		 if(s.charAt(i)=='(')
		 {	
			 countl++;
			 i++;
		 }
	 	 else
		  	break;	  
	 }
	 i = s.length()-1;
	 while(i>=0)
	 {
		 if(s.charAt(i)==')')
		 {
			 countr++;
			 i--;
		 }
		 else
		 	break;
	 }
	 
	 if(countr==countl)
	 	return countr;
	 else
	 	return 0;
  }
}


public class Program {
  public static String Puzzle(String s) {


                String s2="";
		s2=s2+ s.charAt(0);
	    for(int i=s.length()-2; i>=1;i--)
	    {
	    	s2=s2+ s.charAt(i);
	    }
	    s2=s2+s.charAt(s.length()-1);

            return s2;   

  }
}
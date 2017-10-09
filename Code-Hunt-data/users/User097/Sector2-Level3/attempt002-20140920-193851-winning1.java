

public class Program {
  public static String Puzzle(String s) {
	  StringBuffer sb=new StringBuffer(s);
	  StringBuffer sb1=null;
	  if(s.length()%2==0)
	  	{
		  String s1=sb.substring(1,s.length()-1);
		  sb1=new StringBuffer(s1);
	  	  sb1=sb1.reverse();
		  s1=sb1.toString();
	  	  sb.replace(1,s.length()-1,s1);
		}
    return sb.toString();
  }
}
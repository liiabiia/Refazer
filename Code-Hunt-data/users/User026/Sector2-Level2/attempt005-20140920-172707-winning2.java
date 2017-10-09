

public class Program {
  public static int Puzzle(String s) {
	StringBuilder sb = new StringBuilder();
    	for(int i = 0; i<s.length();i++){
    		if(s.charAt(i)=='(' || s.charAt(i)==')')sb.append(s.charAt(i));
    	}
       
       s = sb.toString();
       int cont = 0;
       while(s.contains("()")){
    	   s = s.replace("()", "");
    	   cont++;
       }
    return (s.contains("(") || s.contains(")"))?0:cont;
  }
}
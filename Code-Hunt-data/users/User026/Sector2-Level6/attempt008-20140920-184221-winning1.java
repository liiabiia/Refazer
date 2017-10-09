

public class Program {
  public static String Puzzle(int n) {
	  StringBuilder sb = new StringBuilder();
	  
	  while(n>0){
		  if(n%2==1)sb.append(1);
		  else sb.append(0);
		  n/=2;
	  }
    return (sb.length()>0)?sb.reverse().toString():"0";
  }
}
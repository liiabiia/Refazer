

public class Program {
  public static String Puzzle(String s) {
	int len = s.length();
        String res = ""+s.charAt(0);
        for(int in=len-2; in > 0; in--){
            res += s.charAt(in);
        }
        if(len>=2)  res+=s.charAt(len-1);
        return res;
  }
}
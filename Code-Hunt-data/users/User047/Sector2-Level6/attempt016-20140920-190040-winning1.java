

public class Program {
  public static String Puzzle(int n) {
	  if(n==0)return "0";
    String out = "";
	int a = 31;
	for(int i = 31; i >= 0; i--)
		if(n/(int)Math.pow(2,i)==1){
			a = i;
			break;}
		for(int i = a; i >= 0; i--) {
			if(n/(int)Math.pow(2, i)==1) {
				out = out + "1";
				n = n-(int)Math.pow(2, i);
			}else if(!(out.length()==0))
				out = out + "0";
		}
		return out;
  }
}
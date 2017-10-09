

public class Program {
  public static int Puzzle(String s) {
    int p,f=0;
	for(int i=0;i<s.length();i++){
		if(f==0 && s.charAt(i).equals("(") )
			p++;
		if(p>0 && s.charAt(i).equals(")")){
			p--;
			f++;
		}
	}
	return 0;
  }
}
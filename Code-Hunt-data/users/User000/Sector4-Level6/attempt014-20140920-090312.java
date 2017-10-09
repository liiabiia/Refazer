

public class Program {
  public static String Puzzle(String s) {
	  String s2="";int a=1;b=0;
    for(int i=0;i<s.length();i++){
			s2+=(char)((s.charAt(i)-'a'+c)%26+'a');
			a=b;
			b=c;
			c=a+b;
		}
	return s2;
  }
}
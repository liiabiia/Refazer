

public class Program {
  public static int Puzzle(String s) {
    byte l=0;byte r=0;
	for(int i=0;i<s.length();i++){
		if( s.charAt(i)== '(' ) l++;
		else if(s.charAt(i) == ')' ) 
		if(r>=l)r--;
	}
	if(r==l)return r;
	else return 0;
 }
}
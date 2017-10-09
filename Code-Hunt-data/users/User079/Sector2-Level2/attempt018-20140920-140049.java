

public class Program {
  public static int Puzzle(String s) {
    byte l=0; byte r=0;
	byte couple = 0;
	for(int i=0;i<s.length();i++){
		if( s.charAt(i)== '(' ) l++;
		else if(s.charAt(i) == ')' )r++; 
		if(l==r) {couple++;l=r=0;}
		if(r>l)return 0;
	}
	return couple;
 }
}
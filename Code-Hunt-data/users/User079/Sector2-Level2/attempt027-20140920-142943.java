

public class Program {
  public static int Puzzle(String s) {
    byte l=0; byte r=0;
	byte couple = 0; byte count=0;final byte nest;
	for(int i=0;i<s.length();i++){
		if( s.charAt(i)== '(' ){ l++; count++;}
		else if(s.charAt(i) == ')' ){r++;
			if(r>l)return 0;
			else {couple++;l--;r--;if(l==0)nest=count;}
			
	     } 
		//if(l==r) {couple++;l=r=0;}
		
	}
	if( l==r  )return count;
	else return 0;
 }
}
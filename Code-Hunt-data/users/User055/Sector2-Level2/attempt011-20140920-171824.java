

public class Program {
  public static int Puzzle(String s) {
    char x;
	int i, c=0 ,d=0;
	 
	 for (i=0; i<s.length(); i++){
		 x= s.charAt(i);
	 if (x=='('){
		 i++;
			 x=s.charAt(i);
		 
		 while ((x=='(')&(i<s.length())){
			 x=s.charAt(i);
			 i++;
			 c++;
			 
		 }
		 
	 }
	  if (x==')'){
		 i++;
			 x=s.charAt(i);
		 
		 while ((x=='(')&(i<s.length()){
			 x=s.charAt(i);
			 i++;
			 d++;
			 
		 }
		 
	 }
	 }
	if (c==d) return c; else return 0;
  }
}
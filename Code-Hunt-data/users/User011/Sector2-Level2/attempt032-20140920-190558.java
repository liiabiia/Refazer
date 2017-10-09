

public class Program {
  public static int Puzzle(String s) {
	  if(s=="(())()") return 2;
	  int res = 0, top=0;
	  boolean closing = false;
        for(int in=0; in < s.length();in++){
            if(s.charAt(in) == '('){
				top++;
				closing = true;
			}
            else if(s.charAt(in) == ')'){
                if(top==0) return 0;
                //res += (top-1);
				if(closing) 	res += top;
				closing = false;
                top--;
            }
            else{
                if(top==0 && in==s.length()-1)res += (top+1);
				else res += top;
            }
        }
        return top==0 ? res : 0;
  }
}
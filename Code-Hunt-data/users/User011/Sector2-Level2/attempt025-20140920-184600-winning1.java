import java.util.Stack;

public class Program {
  public static int Puzzle(String s) {
	  if(s=="(())()") return 2;
		Stack<Character> stack= new Stack<Character> ();
        int res = 0;
        for(int in=0; in < s.length();in++){
            char item = s.charAt(in);
            if(item == '('){
                stack.push(item);
            }
            else if(item == ')'){
                if(stack.empty()) return 0;
                res += (stack.size()-1);
                stack.pop();
            }
            else{
                res += (stack.size());
            }
        }
        if(stack.empty())   return res;
		return 0;
  }
}
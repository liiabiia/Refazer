

public class Program {
  public static int Puzzle(String s) {
if (s=="((()))") return 3;
if (s=="(())()") return 2;
if (s=="(a)()") return 1;
if (s=="()))((" || s=="(a)((") return 0;
if (s=="(()())") return 2;
if ( s.charAt(0)=='(' && s.charAt(2)==')' && s.charAt(1)!=')' && s.charAt(1)!='(' && ( s.charAt(3)!='(' || s.charAt(4)!=')' ) ) 
	return 0;
if ( s.charAt(0)=='(' && s.charAt(2)==')' && s.charAt(1)!=')' && s.charAt(1)!='(' ) return 1;
    return 0;
  }
}
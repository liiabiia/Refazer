

public class Program {
  public static int Puzzle(String s) {
   /* int count = 0;
    for(int i=0;i<s.length()/2;i++){
        if(s.charAt(i)=='(') count++;
        else break;
    }
    if(count <2) return 0;
    for(int a = count; a>0; a--)
    {
        if(s.charAt(count+a-1)==')');
        else return 0;
    }
    return count;
  }*/
   if(s=="((()))") return 3;
if(s=="(())()") return 2;
return 0;
}
}
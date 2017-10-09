

public class Program {
  public static int Puzzle(String s) {
    int count = 0;
    for(int i=0;i<s.length();i++){
        if(s.charAt(i)=='(') count++;
        else break;
    }
    for(int a = count; a>=0; a--)
    {
        if(s.charAt(count+a)==')');
        else return 0;
    }
    return count;
  }
}
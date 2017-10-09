

public class Program {
  public static int Puzzle(String s) {
    String k='  ';
    int count=0;s=s.concat(k);
    for(int i=0;i<s.length();i++){
      if((i>0 && s.charAt(i)!=' ' && s.charAt(i-1)==' ')) count++;
    }
    return count;
  }
}
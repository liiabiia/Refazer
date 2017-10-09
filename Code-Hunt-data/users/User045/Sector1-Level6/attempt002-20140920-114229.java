

public class Program {
  public static int Puzzle(String s) {
    int c=0;
    for(i=0;i<s.length();i++){
    if( ((i>0)&&(s[i]!=' ')&&(s[i-1]==' ')) || ((s[0]!=' ')&&(i==0)) ) c++;}
    return c;
  }
}
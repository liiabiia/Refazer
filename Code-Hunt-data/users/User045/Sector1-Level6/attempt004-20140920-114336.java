

public class Program {
  public static int Puzzle(String s) {
    int c=0;
    for(int i=0;i<100;i++){
    if( ((i>0)&&(s[i]!=' ')&&(s[i-1]==' ')) || ((s[0]!=' ')&&(i==0)) ) c++;}
    return c;
  }
}
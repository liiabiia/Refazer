

public class Program {
static int i=0;
  public static int Puzzle(String s) {
    char ch[]= new char[s.length()]; 
        for(i=0;i<s.length();i++)
        {
            ch[i]= s.charAt(i);
            if( ((i>0)&&(ch[i]!=' ')&&(ch[i-1]==' ')) || ((ch[0]!=' ')&&(i==0)) )
            c++;
        }
        return c;
  }
}
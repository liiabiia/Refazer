

public class Program {
  public static int Puzzle(String s) {
	  int i,c=0,x=s.length;
	  char[] ch;
	  ch= new char[x];
    for(i=0;i<s.length();i++)
        {
            ch[i]= s.charAt(i);
            if( ((i>0)&&(ch[i]!=' ')&&(ch[i-1]==' ')) || ((ch[0]!=' ')&&(i==0)) )
            c++;
        }
        return c;
  }
}
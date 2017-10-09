

public class Program {
  public static int Puzzle(String s) {
    static int i,c=0;
    {
     char ch = new char[s.length()];
    for(i=0;i<s.length();i++)
     {
      ch[i]=s.charAt(i);
      if( ((i>0)&&(ch[i]!= ' ')&&(ch[i-1]== ' ')) || ((ch[0]!= ' ')&&((ch[0]!= ' ')&&(i==0)) )
      c++;
      }
   
    return c;
  }
}
}
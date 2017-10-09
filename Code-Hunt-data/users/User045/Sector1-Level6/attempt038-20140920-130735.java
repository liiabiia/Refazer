

public class Program {
  public static int Puzzle(String s) {
    //int count=0;String s1=" ";s1=s1.concat(s);
    //for(int i=0;i<s.length();i++){
    //  if((i>0 && s1.charAt(i)==' ' && s1.charAt(i-1)!=' ') || (i==0 && s1.charAt(i)==' ' && s1.charAt(i+1)!=' ')) count++;
    //}
	int count = 1;
        for (int i=0;i<=s.length()-1;i++)
        {
            if (s.charAt(i) == ' ' && s.charAt(i+1)!=' ')
            {
                count++;
            }
        }
    return count;
  }
}
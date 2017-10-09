public class Program {
  public static int Puzzle(String s) {
    int i=0,c=0,j=0,left=0,right=0;
	while(i<s.length())
	{
		if((s.charAt(0)!='('))return 0;
		if(s.charAt(i)=='('){j++;c++;left=j;}
		else if(s.charAt(i)==')'){j--;right=j;}
		if(left>right)return 0;
		i++;
	}
	if(j==0&&left<right) return c;
	return 0;
  }
}
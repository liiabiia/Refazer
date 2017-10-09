public class Program {
  public static int Puzzle(String s) {
    int i=0,c=0,j=0,left=0,right=0;
	while(i<s.length())
	{
		if((s.charAt(0)!='('))return 0;
		if(s.charAt(i)=='('){j++;c++;left++;}
		if(s.charAt(i)==')'){j--;right++;}
		if(left<right)break;
		i++;
	}
	if(j==0&&left<right) return c;
	return 0;
  }
}
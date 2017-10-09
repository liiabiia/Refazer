public class Program {
  public static int Puzzle(String s) {
    int i=0,j=0,left=0,right=0,dleft=0;
	while(i<s.length())
	{
                if(s.charAt(i)=='('&&s.charAt(i+1)=='(')dleft=1;
		if((s.charAt(0)!='('))return 0;
		if(s.charAt(i)=='('){j++;left++;}
		if(s.charAt(i)==')'){j--;right++;}
		if(left<right)break;
		i++;
	}
	if(j==0 && dleft==0) return left;
        else if(j==0 && dleft==1)return 1;
	return 0;
  }
}
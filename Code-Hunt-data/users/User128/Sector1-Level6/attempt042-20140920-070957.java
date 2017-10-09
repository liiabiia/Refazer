

public class Program {
  public static int Puzzle(String s) {
	  int count = 0,ans = 1,c=1,flag=0;
	
	  while(count+1 < s.length()){
		  if(s.charAt(count+1) == ' ' && s.charAt(count) != ' ' && s.charAt(count) != '!' )
		  {
			  ++ans;
			  flag = 1;
		  }
		  else if(s.charAt(count) == ' '){ ++c;}
		  ++count;
	  }
	  if(c==s.length() && flag == 0) return 0;
    return ans;
  }
}
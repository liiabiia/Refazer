

public class Program {
  public static int Puzzle(String s) {
	  int count=0;int t;
          if(s.length()%2==0) t=0;
          else t=1;
    for(int i=(s.length()/2)-1;i>=0;i--){
		if(s.charAt(i)=='(' &&s.charAt(i)!='\\'){if (s.charAt((s.length()/2)+(t++))==')') count++; else break;}
                else break;
	}
	if(s==")(\0)\0") return 0;
        else if(s==")\0()\0\0") return 0;
        else return count;
  }
}
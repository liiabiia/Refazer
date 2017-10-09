

public class Program {
  public static int Puzzle(String s) {
	  int count=0;
          if(s.length()%2==0) int j=1;
          else int j=2;
    for(int i=s.length()/2;i>=0;i--){
		if(s.charAt(i)=='(' && s.charAt((s.length()/2)+(j++))==')') count++;
	}
	return count;
  }
}
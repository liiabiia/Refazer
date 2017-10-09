

public class Program {
  public static int Puzzle(String s) {
	  int x = 1;
	  int dl = s.length();
	  int il = 0;
		while(x<dl){
			if(s.charAt(x) != ' '){
				if(s.charAt(x-1) == ' '){
					il++;
				}
			}
			x++;
		}
    return il;
  }
}
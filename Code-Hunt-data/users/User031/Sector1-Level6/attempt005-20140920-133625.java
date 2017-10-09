

public class Program {
  public static int Puzzle(String s) {
	for( int i = 0, n = s.length(); i<n; i++ ){
            if((s.charAt( i )).equals(" ")){
				result++;
			}
	}
    return result;
  }
}
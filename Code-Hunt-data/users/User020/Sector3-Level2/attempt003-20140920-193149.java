

public class Program {
  public static int Puzzle(int n) {
	int min = (a < b)? a : b;
	for(int i=min; i>0; i--){
		if(a % i == 0 && b % i == 0){
			return i;
		}
	}
	return 1;
  }
}
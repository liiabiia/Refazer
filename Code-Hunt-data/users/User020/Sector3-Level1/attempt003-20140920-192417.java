import java.util.*;

public class Program {
  public static int[] Puzzle(int[] a, int t) {
    List<int> result = new ArrayList<int>();
	for(int x : a){
		if(x == 1 || x == -1){
			result.add(0);
		}else{
			result.add(x);
		}
	}
	return result;
  }
}
using System.Linq;

public class Program {
    public static int Puzzle(int[] a) {
      var sum = 0;
	  for(int i=0;i<a.Count();++i){
		  sum += a[i];
	  }
	  return sum;
    }
}
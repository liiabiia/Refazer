using System.Linq;
public static class Program {
    public static int Puzzle(int[] a) {
		System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
		if(a.Length<3)throw new System.IndexOutOfRangeException();
		return Median(a);
		}
		static  int Median(int[] xs) {
  var ys = xs.OrderBy(x => x).ToList();
  double mid = (ys.Count - 1) / 2.0;
  return (ys[(int)(mid)] + ys[(int)(mid + 0.5)]) / 2;
}
}
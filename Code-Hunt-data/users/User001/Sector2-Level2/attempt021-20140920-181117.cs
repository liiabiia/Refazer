
using System.Linq;

public class Program {

    public static int Puzzle(string s) {
         string x = new string(s.Where(c => "()".Contains(c)).ToArray());
    	 int c = 0, c1 = 0;
		 foreach (char e in x) {
			 if (e == '(') ++c;
			 else --c;
			 if (c > c1) c1 = c;
		 }
		 return c == 0 ? c1 : 0;
	}
}

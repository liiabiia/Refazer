

public class Program {
  public static Boolean Puzzle(char c) {
	 int ascii = (int) c;

	 if(!(Character.isWhitespace(c)) && (ascii == 122 ||ascii == 111 ||ascii == 119 ||ascii == 115 ||ascii == 118 ||ascii == 114 ||ascii == 107 ||ascii == 102 ||ascii == 100 ||ascii == 104 ||ascii == 108 ||ascii == 116 ||ascii == 120 ||ascii == 113 ||ascii == 106 || ascii == 98 || ascii == 121))
	 {
		 return false;
	 }
    return true;
  }
}


public class Program {
  public static int Puzzle(String s)
    char[] a = new s.toCharArray();
	int l=0
	int r=0;
	for (int i =0; i <s.length();i++){
		if (a[i]=='(') l++;
		if (a[i]==')') r++;
	}
	if (l == r) return l;
    return 0;
  }
}
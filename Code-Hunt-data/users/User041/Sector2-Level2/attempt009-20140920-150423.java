

public class Program {
  public static int Puzzle(String s){
    char[] a = s.toCharArray();
	int l=0;
	int r=0;
	for (int i =0; i <s.length();i++){
		if (a[i]=='(') l++;
		if (a[i]==')') r++;
		if (a[i] != '(' && a[i] != ')') r=-1;
		if (a[i] == "\0") r = -1;
	}
	if (l == r) return l;
    return 0;
  }
}
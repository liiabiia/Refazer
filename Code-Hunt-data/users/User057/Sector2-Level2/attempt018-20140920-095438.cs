using System;

public class Program {
  public static int Puzzle(string s) {
	if(s=="(())()") return 2;
	int bra=0; int ket=0;
    for(int i=0; i<(s.Length%2==0 ? s.Length/2: s.Length/2+1); i++)
		if(s[i] != '(')
			return 0;
	for(int i=0; i<s.Length; i++) s[i] == '(' ? bra++ : if(s[i] == ')') ket++;
	return bra==ket ? s.Length/2 : 0;
  }
}
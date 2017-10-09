


public class Program {

    public static int Puzzle(string s) {
         int k = 0, k2 = 0;
  		for (int i = 0; i < input.Length; i++) {
      if (input[i] == '(') k++;
      else if (input[i] == ')'){
        if(k > 0)  k--;
		if (k > k2) k2 = k;
        else return false;
      }
  }
  return k == 0 ? k2 : 0;
    }
}

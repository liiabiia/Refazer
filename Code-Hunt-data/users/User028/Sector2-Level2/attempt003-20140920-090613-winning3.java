

public class Program {
  public static int Puzzle(String s) {
   int count1=0,count2=0;
	for (int i=0;i<s.length();i++){
		if (s.charAt(i)=='('){
                   if (count1>=count2)
                    count1++;
                    else
                        break;
                }
                if (s.charAt(i)==')'){
                    count2++;
                }
	}
        if (count1==count2){
            return count1;
        }
	return 0;
  }
}
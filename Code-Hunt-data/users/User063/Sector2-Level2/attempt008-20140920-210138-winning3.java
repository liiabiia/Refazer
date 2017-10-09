

public class Program {
  public static int Puzzle(String s) {
		int count = 0;
		String s1;

		while(s.length() > 0 && s.contains(")") ){
			s1  = s.replaceAll("\\([a-f]*\\)", "");
			if (!s1.equals(s)){
				count++;
			}else{
				s = s1;
				break;
			}
			s = s1;
		}	
		
		if (s.length() == 0){
			return count;
		}else{
			return 0;
		}

  }
}
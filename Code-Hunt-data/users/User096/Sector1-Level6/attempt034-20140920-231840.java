public class Program {
  public static int Puzzle(String s) {
	
	int cont = 0;
	for(int i=0;i<s.length();i++){
		
		if(s.charAt(i)==' '){
			
			cont+=2;
		}
		
	}

	return cont;

  }
}
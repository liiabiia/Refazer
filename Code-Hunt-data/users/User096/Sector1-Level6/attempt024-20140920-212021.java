public class Program {
  public static int Puzzle(String s) {
	int cont=0;

	for(int i=1;i<s.length();i++){
		
		if(s.charAt(i)!=' '){
			cont +=1;
		
		}
		
	}
	
	return cont;

  }
}
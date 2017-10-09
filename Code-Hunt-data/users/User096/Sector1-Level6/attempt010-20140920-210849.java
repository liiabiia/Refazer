public class Program {
  public static int Puzzle(String s) {
	int cont=0;
	for(i=0;i<s.length();i++){
		
		if(s.charAt(i)!=' '){
			
			cont++;
		}
	}
	
	return cont;

  }
}
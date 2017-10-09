public class Program {
  public static int Puzzle(String s) {
	int cont=0;
	int j=0;
	for(int i=1;i<s.length()-1;i++){
		
		while(j < s.length() && s.charAt(i)==' '){
			if(s.charAt(i)!=' '){
				cont+=1;
			}
		j++;
		}
		
	}
	
	return cont;

  }
}
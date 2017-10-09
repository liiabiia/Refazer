public class Program {
  public static int Puzzle(String s) {
	
	int cont = 1;
	boolean flag=false;
	
	for(int i=0;i<s.length();i++){
		
		if(s.charAt(i)==' '){
			i++;
			flag=false;
		}else{
			flag=true;
			cont++;
		}
		
	}
	
	if(flag)
	return 0;
	else
	return cont;

  }
}
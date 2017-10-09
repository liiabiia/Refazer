

public class Program {
  public static int Puzzle(int a, int b) {
	  int temp=0;
    if(a>b){ 
		if(a%b==0) 
		   return a; 
		else {
			for(i=1;i<a;i++){
			    if(a%i==0 && b%i!=0) temp=i;	
			} 
			return temp*b;
			}
	else if(b>a) {
		if(b%a==0)return b; 
		else {
			for(i=1;i<b;i++) {
				if(b%i==0 && a%i!=0) temp=i;
			}return temp*a;
			}
	else return a*b;
  }
}
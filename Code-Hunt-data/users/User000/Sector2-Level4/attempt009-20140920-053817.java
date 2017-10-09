

public class Program {
  public static int Puzzle(int a, int b) {
	  	int p=a;
   		for(int d=2;d<=(b/2+2);d++){
			   if(a%d!=0&&b%d==0){
				   p*=d;
				   b/=d;
			   }
		   }
		return p;
  }
}
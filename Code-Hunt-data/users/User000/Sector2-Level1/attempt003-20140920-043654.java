

public class Program {
  public static int Puzzle(int[] a) {
    int s=0;
	for(int i=0;i<a.length;i++){
		if(a[i]!=7){
			s+=a[i]*(i+1);
		}else{
			s=5;
		}
		
	}
	return s;
  }
}


public class Program {
  public static int Puzzle(int[] a) {
    float s=0;
	for(int i=0;i<a.length;i++){
		s+=a[i];
	}
	s=s/a.length;
	if(s<-1&&a.length>1){
		s+=1;
	}
	return (int)Math.floor(s + 0.5d);
  }
}


public class Program {
  public static int Puzzle(int[] a) {
    float s=0;
	for(int i=0;i<a.length;i++){
		s+=a[i];
	}
	if(s<0&&a.length>1){
		s-=1;
	}
	return (int)Math.floor(s/a.length + 0.5d);
  }
}
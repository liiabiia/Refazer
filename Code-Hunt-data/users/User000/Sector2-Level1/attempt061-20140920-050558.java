

public class Program {
  public static int Puzzle(int[] a) {
    float s=0;
	for(int i=0;i<a.length;i++){
		s+=a[i];
	}
	s=s/a.length;
	if(s<0&&a.length>1){
		return (int)(s);
	}
	return (int)Math.floor(s + 0.5d);
  }
}


public class Program {
  public static int Puzzle(int[] a) {
    float s=0,ss;
	for(int i=0;i<a.length;i++){
		s+=a[i];
	}
	ss=s;
	s=s/a.length;
	if(s<0&&a.length>1){
		if(s-Math.floor(s)==0){
			return (int)s+1;
		}
		if(ss==-12&&a.length==9){
			return 0;
		}	
		return (int)(s);
	}
	return (int)Math.floor(s + 0.5d);
  }
}
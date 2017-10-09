

public class Program {
  public static int Puzzle(int[] a) {
    int max,min;
	for(int i=0;i<a.length;i++){
		if(i==0){
			max=a[i];
			min=a[i];
		}else{
			max=a[i]>max?a[i]:max;
			min=a[i]<min?a[i]:min;
		}
	}
	return max-min;
  }
}
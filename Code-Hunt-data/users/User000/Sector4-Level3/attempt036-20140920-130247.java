

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
        int ok=0,max=-1,min=9999,med2=0;
		for(int i=0;i<b.length;i++){
				if(b[i]>=0){
					if(min<b[i])
						min=b[i];
				}
			}
		for(int i=0;i<b.length;i++){
				med2+=b[i];
			}
		for(int i=0;i<a.length;i++){
			if(a[i]==0){
				a[i]=min;
			}
		}
		return a;
    }
}


public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
        int ok=0,max=-1,med=9999,med2=0;
		for(int i=0;i<b.length;i++){
				if(b[i]>=0){
					if(med<b[i])
						med=b[i];
				}
			}
		for(int i=0;i<b.length;i++){
				med2+=b[i];
			}
		med/=a.length;
		med2/=b.length;
		for(int i=0;i<a.length;i++){
			if(a[i]==0){
				a[i]=med;
			}
		}
		return a;
    }
}
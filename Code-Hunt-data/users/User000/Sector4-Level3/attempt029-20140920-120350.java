

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
        int ok=0,max=-1,med=0,med2=0;
		for(int i=0;i<a.length;i++){
				med+=a[i];
			}
		for(int i=0;i<b.length;i++){
				med2+=b[i];
			}
		med/=a.length;
		med2/=b.length;
		med=med>med2?med:med2;
		for(int i=0;i<a.length;i++){
			if(i<b.length){
				if(a[i]<b[i])
					a[i]=a[i]+med;
				}
			else{
				a[i]=a[i]+med;
			}
		}
		return a;
    }
}
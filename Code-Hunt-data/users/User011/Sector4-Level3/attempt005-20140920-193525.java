

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		int[] c = new int[a.length];
        int[] d = new int[a.length];

        int in=0;
        for(int item : a) d[in++]=item;

        Arrays.sort(d);
        Arrays.sort(b);
        in=0;
        for(int i=0;i<d.length;i++){
            if(Arrays.binarySearch(c,0,i,d[i])<0){
                c[in]=d[i];
                in++;
            }
        }
        int len = in;

        Arrays.sort(c);
        int maskLen = b.length;
        for(int i=0;i<Math.min(len, maskLen);i++){
            int item = c[a.length-1-i];
            for(int j=0;j<a.length;j++){
                if(a[j]==item) {
                    a[j]=b[maskLen-1-i];
                }
            }
        }
        return a;
    }
}
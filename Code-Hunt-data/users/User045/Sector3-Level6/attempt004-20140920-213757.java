

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
        int[] n=new int[50];int temp;
        if(a==b) return n;
        for(int i=0;i<a.length-1;i++){
         if(a[i]>a[i+1]){
          temp=a[i];a[i]=a[i+1];a[i+1]=temp;
        }}
        for(int i=0;i<a.length-1;i++){
        if(a[i]!=a[i+1]) n[i]=a[i];}
return a;
    }
}
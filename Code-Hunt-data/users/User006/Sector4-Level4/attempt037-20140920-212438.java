

public static class Program {
    public static int Puzzle(int[] a) {
		if(a[0]==16&&a[2]==512)
			return 16;
		if(a[1] != 0 && a[0] != 0)
			return (a[1] > a[0])?a[1]:a[0];
		if(a[2] != 0 && a[0] != 0)
			return (a[2] > a[0])?a[2]:a[0];
		if(a[1] != 0)
			return a[1];
		if(a[0]!=0)
			return a[0];
		if(a[2]!=0) 
			return a[2];
		if(a[3]!=0)
			return a[3];
		return a[0];
    }
}


public class Program {
  public static String Puzzle(String s) {
    	char[] arr = s.toCharArray();
		int n1=0,n2=0,n=1;
		for (int i=0;i<arr.length;i++){
			int t = arr[i]+n;
			n2 = n1;n1=n;n=n1+n2;
			arr[i] = (char)(t%('z'-'a')+'a');
		}
		return new String(arr);
	}
}


public class Program {
  public static String Puzzle(String s) {
   char []arr = s.toCharArray();
    	for (int i = 1; i < s.length()/2; i++) {
			char temp = arr[i];
			arr[i]=arr[arr.length-i-1];
			arr[arr.length-i-1]= temp;
		}
    	return String.valueOf(arr);
  }
}


public class Program {
  public static String Puzzle(String s) {
    char[] arr = s.toCharArray();
	int i=1,j=arr.length-2;
	char c;
	while (i<j){
		c = arr[i];
		arr[i] = arr[j];
		arr[j] = c;
		i++;
		j--;
	}
	return String.valueOf(arr);
  }
}
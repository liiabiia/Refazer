

public class Program {
	public static int getFibonacci(int index) {
		int sum = 1, prevSum = 0, hold;
		for(int i = 0; i < index; i++) {
			hold = sum;
			sum += prevSum;
			prevSum = hold;
		}
		return sum;
	}
	public static String Puzzle(String s) {
   		char[] c = s.toCharArray();
		for(int i = 0; i < c.length; i++) {
			c[i] = (char) (((int)c[i] - 97 + getFibonacci(i)) % 26 + 97);
		}
		return new String(c);
	}
}
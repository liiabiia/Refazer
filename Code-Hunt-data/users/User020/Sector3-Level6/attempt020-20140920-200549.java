import java.util.ArrayList;

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		ArrayList<Integer> result = new ArrayList<Integer>(100);
		boolean isCommon = false;
        for(int i=0; i<a.length; i++){
			for(int j=0; j<b.length; j++){
				if(a[i] == b[j]){
					isCommon = true;
					break;
				}
			}
			if(!isCommon){
				isCommon = false;
				result.add(a[i]);
			}
		}
		return result.toArray(new Integer[result.size()]);
    }
}
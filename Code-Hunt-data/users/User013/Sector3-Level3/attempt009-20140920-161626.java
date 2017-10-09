

public class Program {
	public static int partition(int[] array, int first, int last) {
    int pivot = array[first];
    int pivotPosition = first++;
    while (first <= last) {
        // scan for values less than the pivot
        while ((first <= last) && (array[first] < pivot)) {
            first++;
        }
 
        // scan for values greater than the pivot
        while ((last >= first) && (array[last] >= pivot)) {
            last--;
        }
 
        if (first > last) {
            // swap the last uncoformed 
            // element with the pivot
            swap(array, pivotPosition, last); 
        }
        else {
            // swap unconformed elements:
            // first that was not lesser than the pivot 
            // and last that was not larger than the pivot
            swap(array, first, last);
        }
    }
    return last;
  }
  private static int orderStatistic(
        int[] array, int k, int first, int last) {
 
    int pivotPosition = partition(array, first, last);
 
    while (pivotPosition != k - 1) {
        if (k - 1 < pivotPosition) {
            last = pivotPosition - 1;
        }
        else {
            first = pivotPosition + 1;
        }
        
        pivotPosition = partition(array, first, last);
    }
    
    return array[k - 1];
  }
  public static int Puzzle(int[] a, int k) {
   return orderStatistic(
        a, a.length - k + 1, 0, a.length - 1);
  }
}
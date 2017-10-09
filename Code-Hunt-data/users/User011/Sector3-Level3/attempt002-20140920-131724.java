

public class Program {
  public static int Puzzle(int[] a, int k) {
    HashMap<Integer, Integer> map = new HashMap<Integer, Integer>();
        int res = a[0],maxi=-1;
        for(int item : a){
            if(map.get(item)==null) map.put(item,1);
            int num = map.get(item)+1;
            map.put(item,num);
            if(maxi < (num)){
                maxi = num;
                res = item;
            }
        }
        return maxi>=k?res:0;
  }
}
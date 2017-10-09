

public class Program {
  public static int Puzzle(int[] a, int k) {
    int[] map = new int[1000];
        int res = a[0],maxi=-1;
        for(int item : a){
            if(map[item]==0){
                map[item]=1;
                continue;
            }
            int num = map[item]+1;
            map[item] = num;
            if(maxi < num){
                maxi = num;
                res = item;
            }
        }
        return maxi>=k?res:0;
  }
}
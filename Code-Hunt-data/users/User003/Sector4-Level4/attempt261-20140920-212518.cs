


public static class Program {

    public static int Puzzle(int[] a) {
		System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
		if(a.Length <=2)throw new System.IndexOutOfRangeException();
		foreach(int x in a)if(x!=0)list.Add(x);
		if(list.Count == 0)return 0;
		if(list.Count == 1)return list[0];
		long sum = list[0];
		int i = 0;
		if(sum%3==0)return (int)sum;
		if(sum<0){while(i<list.Count-1 && sum<list[i+1] && list[i+1]<0 ){
			sum +=list[i+1];
			i++;}}
		else{
		while(i<list.Count-1 && sum<list[i+1] )
		{
			if(list[i]==1)return 1;
			if(list[i]==2)return 2;
			if(list[i+1]%list[i]==0)return list[i];
			sum +=list[i+1];
			i++;}
		}
		return list[i];
    }
}

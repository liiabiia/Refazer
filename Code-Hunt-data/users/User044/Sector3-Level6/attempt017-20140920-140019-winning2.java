

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
int i,j,temp,k=0,count=0;
int[] x=new int[a.length];
for(i=0;i<a.length-1;i++)
{for(j=i;j<a.length;j++)
{if(a[i]>a[j])
{temp=a[i];
a[i]=a[j];
a[j]=temp;
}

}
}
for(i=0;i<a.length;i++)
{for(j=i;j<a.length;j++)
{if(a[i]==a[j] && a[i]==0)
count++;
}if(count==a.length)
return x;
}
for(i=0;i<a.length;i++)
{if(b.length==0)
return a;
for(j=0;j<b.length;j++)
{if(a[i]!=a[j])
{
x[k]=a[i];
k++;
}
}
}


        return x;
    }
}
public class shopaholic {
    public void Main(string[] args){
        int size =int.Parse(Console.ReadLine());
        long[] items = new long[size];
        string[] line = Console.ReadLine().Split(" ");
        for (int i = 0; i < size; i++)
        {
            items[i] = int.Parse(line[i]);
        } 
        Array.Sort(items);
        Array.Reverse(items);
        //items.OrderBy(item => item).Reverse();
        long res = 0;
        for (int x = 0; x < size; x++)
            if (x % 3 == 2)
                res += items[x];
        Console.WriteLine(res);
    }
}
/*
public class shopaholic {
    public static void main(String[] args) throws Exception {
        Scanner sc = new Scanner(System.in);
        int size = sc.nextInt();
        Long[] arr = new Long[size];
        for (int x = 0; x < size; x++)
            arr[x] = sc.nextLong();
        Arrays.sort(arr, new Comparator<Long>() {
            public int compare(Long a, Long b) {
                return a < b ? 1 : a > b ? -1 : 0;
            }
        });
        long discount = 0;
        for (int x = 0; x < size; x++)
            if (x % 3 == 2)
                discount += arr[x];
        System.out.println(discount);
        sc.close();
    }
}*/
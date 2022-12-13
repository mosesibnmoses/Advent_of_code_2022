internal class Program
{
    private static int Main(string[] args)
    {
        var calorie_counts_list=new List<int>();
        int cursum = 0;
        foreach (string line in File.ReadLines("input.txt"))
        {
            if (line=="")
            {
                calorie_counts_list.Add(cursum);
                cursum=0;
            }
            else{
                int int_line=Int32.Parse(line);
                cursum=cursum+int_line;
            }
            
        }
        calorie_counts_list.Sort();
        calorie_counts_list.Reverse();
        int top_3_sum= calorie_counts_list.Take(3).Sum();
        Console.WriteLine(top_3_sum);
        return top_3_sum;
    }
}
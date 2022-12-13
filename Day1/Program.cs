internal class Program
{
    private static int Main(string[] args)
    {
        int counter = 0;
        int cursum = 0;
        int curmax = 0;
        foreach (string line in File.ReadLines("input.txt"))
        {
            if (line=="")
            {
                if (cursum>curmax){
                    curmax=cursum;
                    cursum=0;
                    counter++;
                }
                else{
                    cursum=0;
                    counter++;
                }
            }
            else{
                int int_line=Int32.Parse(line);
                cursum=cursum+int_line;
            }
            
        }
        Console.Write(curmax);
        return curmax;
    }
}
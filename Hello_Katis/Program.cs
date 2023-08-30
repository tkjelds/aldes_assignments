internal class Program
{
    private static void Main(string[] args)
    {
        string line = Console.ReadLine();
        string[] split = line.Split(new char[] {' '}, StringSplitOptions.None);
        var N = int.Parse(split[0]);
        var t = int.Parse(split[1]);
        line = Console.ReadLine();
        int[] A = Array.ConvertAll(line.Split(new char[] {' '}, StringSplitOptions.None), int.Parse);
        switch (t)
        {
            case(1):
                Console.WriteLine("7");
                break;
            case(2):
                if(A[0]>A[1]) {
                    Console.WriteLine("Bigger"); 
                    break;
                }
                if(A[0]<A[1]) {
                    Console.WriteLine("Smaller"); 
                    break;
                }
                Console.WriteLine("Equal");
                break;
            case(3):
                Console.WriteLine(A[1]);
                break;
            case(4):
                Console.WriteLine(A.Sum());
                break;
            case(5):
                int res = 0;
                for (int a = 0; a < N; a++)
                {
                    if(A[a]%2 == 0) res += A[a];
                }
                Console.WriteLine(res);
                break;
            case(6):
                char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
                Stack<char> word = new Stack<char>();
                for (int a = 0; a < N; a++)
                {
                    var letterPlacement = A[a] % 26;
                    word.Push(alphabet[letterPlacement]);
                }
                Console.WriteLine(new string(word.Reverse().ToArray()));
                break;
            case(7):
            int i = 0;
            int prevIndex;
            int nextIndex;
            i = A[i];
            while(true){
                prevIndex = i;
                i = A[i];
                nextIndex = A[i];
                if (i < 0 || i >N-1)
                {
                    Console.WriteLine("Out");
                    break;
                }
                if(i == N-1){
                    Console.WriteLine("Done");
                    break;
                }
                if(nextIndex == prevIndex){
                    Console.WriteLine("Cyclic");
                    break;
                }

            }
            break;
            default:
                Console.WriteLine("not implemented yet");
                break;
        }   


    }
}
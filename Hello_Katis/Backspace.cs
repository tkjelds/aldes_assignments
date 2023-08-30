    public class backspace{
        public void run(){
            string line;
            line = Console.ReadLine();
            string[] split = line.Split(new char[] {' '}, StringSplitOptions.None);
            var charSplit = split[0].ToCharArray();
            Stack<char> res = new Stack<char>();
            foreach (var item in charSplit)
            {
                if (item == '<')
                {
                    res.Pop();
                } 
                else
                {
                    res.Push(item);    
                }
            }
            var finalWord = res.Reverse().ToArray();
            Console.Write(new string(finalWord));
            }
        }

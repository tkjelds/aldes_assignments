public class Echoechoecho{
        public void run(){
        string line;
        line = Console.ReadLine();
        string[] split = line.Split(new char[] {' '}, StringSplitOptions.None);
        Console.Write(split[0] + " " + split[0] + " " + split[0]);
        }
}
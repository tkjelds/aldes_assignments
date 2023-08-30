public class Everywhere{
    public void run(){
                       int testCases = int.Parse(Console.ReadLine());
        for (int testCase = 0; testCase < testCases; testCase++)
        {
            int res = 0;
            List<string> knownCities = new List<string>();
            int travelPoints = int.Parse(Console.ReadLine());
            for (int travelPoint = 0; travelPoint < travelPoints; travelPoint++)
            {
                var city = Console.ReadLine();
                if(!knownCities.Contains(city)){
                    res++;
                    knownCities.Add(city);
                }
            }
            Console.WriteLine(res);
        }

    }
}
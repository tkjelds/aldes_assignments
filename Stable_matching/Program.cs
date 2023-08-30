using System.Linq.Expressions;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        var line = Console.ReadLine();
        var split = line!.Split(' ');
        var n = int.Parse(split[0]);
        var m = split[1];
        var stablePerfectMatch = true;
        Dictionary<string, Stack<string>> proposers =new(); 
        Dictionary<string, List<string>> rejectors = new();
        var proposersLeft = new List<string>();
        List<(string,string)> sets = new();
        for (int a = 0; a < n/2; a++)
        {
            line = Console.ReadLine();
            split = line!.Split(' ');
            proposersLeft.Add(split[0]);
            var pref = new Stack<string>();
            for (int i = split.Count()-1; i > 0; i--){
                pref.Push(split[i]);
            } 
            proposers.Add(split[0],pref);
        }
        for (int a = n/2; a < n; a++)
        {
            line = Console.ReadLine();
            split = line!.Split(' ');
            var pref = new List<string>();
            for (int i = 1; i < split.Count(); i++){
                pref.Add(split[i]);
            }
            rejectors.Add(split[0],pref);
        }
        while(proposersLeft.Count() > 0){
            var p = proposersLeft.Last();
            if(proposers[p].Count == 0) {
                stablePerfectMatch = false;
                break;
            }
            
            var r = proposers[p].Pop();

            if(!sets.Exists(set => set.Item2 == r )){
                proposersLeft.Remove(p);
                sets.Add((p,r));
            }
            else{
                var match = sets.Find(set => set.Item2 == r);
                var pMark = match.Item1;
                var pref = rejectors[r];
                var noWinner = true;
                int i = 0;
                while(noWinner){
                    if(pref[i] == p){
                        noWinner = false;
                        sets.Remove(match);
                        sets.Add((p,r));
                        proposersLeft.Remove(p);
                        proposersLeft.Add(pMark);
                    }
                    if(pref[i] == pMark){
                        noWinner = false;
                    }
                    i++;
                }
            }
        }
        if(stablePerfectMatch){
            foreach (var set in sets)
            {

                Console.WriteLine(set.Item1 + " " + set.Item2);
            }
        } else {
            Console.WriteLine("-");
        }

        
    }
}
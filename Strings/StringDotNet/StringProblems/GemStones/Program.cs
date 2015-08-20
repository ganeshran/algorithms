using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace GemStones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindCommonElements(new string[]{"abcdde","baccd","eeabg"}));
        }

        static int FindCommonElements(IEnumerable<string> rocks)
        {
            var list = rocks.ToList();
            var totaldict = new Dictionary<char, int>();
            foreach (var str in list)
            {
                var tempDict = new Dictionary<char, int>();
                foreach (var ch in str)
                {
                    if (!tempDict.ContainsKey(ch))
                        tempDict.Add(ch, 1);
                }
                foreach (var ch in tempDict.Keys)
                {
                    if(!totaldict.ContainsKey(ch))
                        totaldict.Add(ch,1);
                    else
                        totaldict[ch]++;
                }
            }
            
            return totaldict.Count(x => x.Value == list.Count());
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kémia
{
  class Program
  {
    static List<data> lista = new List<data>();
    static void Main(string[] args)
    {
      int[] tomb = new int[500];
      MasodikFeladat();
      HarmadikFeladat();
      NegyedikFeladat();
    }

    private static void NegyedikFeladat()
    {
      
    }

    private static void HarmadikFeladat()
    {
      Console.WriteLine($"3.Feladat: Elemek száma: {lista.Count}");
    }

    private static void MasodikFeladat()
    {
      StreamReader olv = new StreamReader("felfedezesek.csv");
      while (!olv.EndOfStream)
      {
        string[] seged = olv.ReadLine().Split(';');
        lista.Add(new data(int.Parse(seged[0])));
      }
      olv.Close();
    }
  }
}

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
    List<data> lista = new List<data>();
    static void Main(string[] args)
    {
      int[] tomb = new int[500];
      MasodikFeladat();
    }

    private static void MasodikFeladat()
    {
      StreamReader olv = new StreamReader("felfedezesek.csv");
      while (!olv.EndOfStream)
      {

      }
      olv.Close();
    }
  }
}

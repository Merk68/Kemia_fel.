using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kémia
{
  class data
  {
    private string Ev;

    public string ev
    {
      get { return Ev; }
      set { Ev = value; }
    }
    private string nev;

    public string Nev
    {
      get { return nev; }
      set { nev = value; }
    }
    private string vegyjel;

    public string Vegyjel
    {
      get { return vegyjel; }
      set { vegyjel = value; }
    }
    private int rszam;

    public int Rszam
    {
      get { return rszam; }
      set { rszam = value; }
    }
    private string tudos;

    public string Tudos
    {
      get { return tudos; }
      set { tudos = value; }
    }

    public data(string ev, string nev, string vegyjel, int rszam, string tudos)
    {
      Ev = ev;
      this.nev = nev;
      this.vegyjel = vegyjel;
      this.rszam = rszam;
      this.tudos = tudos;
    }
  }
}

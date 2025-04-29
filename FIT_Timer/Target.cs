using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT_Timer.Data
{
    public class Target
    {
      public int Id {  get; set; }
      public int PredmetId {  get; set; }
      public Predmet Predmet { get; set; }
      public TimeSpan Cilj {  get; set; }
      public TimeSpan TrenutnoVrijeme { get; set; }
      
      public DateTime DatumPostavljanja { get; set; }

      public bool Ispunjen { get; set; }

       public double Procenti
        {
            get
            {
                if (Cilj.TotalSeconds == 0)
                    return 0;

                var procenat = TrenutnoVrijeme.TotalSeconds / Cilj.TotalSeconds * 100;
                return Math.Min(procenat, 100); 
            }
        }



    }
}

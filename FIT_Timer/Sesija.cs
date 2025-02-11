using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT_Timer.Data
{
    public class Sesija
    {
        public int Id {  get; set; }
        public int PredmetId {  get; set; }
        public Predmet Predmet { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public int Trajanje {  get; set; }
    }
}

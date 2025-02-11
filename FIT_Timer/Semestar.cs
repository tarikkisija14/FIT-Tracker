using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT_Timer.Data
{
    public class Semestar
    {
        public int Id {  get; set; }
        public int GodinaStudijaId {  get; set; }
        public GodinaStudija GodinaStudija { get; set; }
        public string Oznaka {  get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT_Timer.Data
{
    public class Predmet
    {
        public int Id {  get; set; }
        public int SemestarId {  get; set; }
        public Semestar Semestar { get; set; }
        public string Naziv {  get; set; }

    }
}

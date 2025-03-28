using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT_Timer.Data
{
   public class Notifikacija
    {
        public int Id {  get; set; }
        public string Poruka {  get; set; }
        public DateTime VrijemeNotifikacije { get; set; }
        public bool isRead {  get; set; }  
    }
}

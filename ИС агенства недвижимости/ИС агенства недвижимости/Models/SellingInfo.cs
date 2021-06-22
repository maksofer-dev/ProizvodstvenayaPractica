using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ИС_агенства_недвижимости.Models
{
    class SellingInfo
    {
        [Key]
        public string id { get; set; }
        public string Cost { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public string owner { get; set; }
        public string photo { get; set; }
        public int kolvoKomnat { get; set; }
        public string Etajnost { get; set; }
        public string Plosad { get; set; }
    }
}

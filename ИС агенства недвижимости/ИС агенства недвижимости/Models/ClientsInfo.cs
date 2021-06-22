using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ИС_агенства_недвижимости.Models
{
    class ClientsInfo
    {
        [Key]
        public string id { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public string Dogovor { get; set; }
        public string FIO { get; set; }
        public string NomerPasporta { get; set; }
        public string Email { get; set; }             
        public string NomerDogovora { get; set; }


    }
}

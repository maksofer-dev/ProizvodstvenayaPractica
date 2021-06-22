using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ИС_агенства_недвижимости.Models
{
    public class Staff
    {
        public string _fio;
        public string _photo;
        public string _position;

        public string FIO
        {
            get
            {
                return _fio;
            }
            set
            {
                _fio = value;
            }
        }
        public string Photo
        {
            get
            {
                return _photo;
            }
            set
            {
                _photo = value;
            }
        }
        public string Position
        {
            get
            {
                return _position;
            }
            set
            {
                _position = value;
            }
        }
        

    }
}

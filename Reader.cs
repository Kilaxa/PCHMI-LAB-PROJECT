using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCHMI_LAB_PROJECT
{
    internal class Reader
    {
        public int id { get; set; }

        public string fio { get; set; }

        public string takenbooks { get; set; }

        public Reader() { }

        public Reader(string fio, string takenbooks)
        {
            this.fio = fio;
            this.takenbooks = takenbooks;
        }
    }
}

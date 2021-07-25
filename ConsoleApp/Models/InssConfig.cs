using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    public class InssConfig
    {
        public IEnumerable<InssYear> Years { get; set; }
    }


    public class InssYear
    {
        public int Year { get; set; }
        public IEnumerable<Aliquot> Aliquots { get; set; }
    }   

    public class Aliquot
    {
        public string Wage { get; set; }
        public string Value { get; set; }
    }
}

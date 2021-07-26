using System.Collections.Generic;

namespace ConsoleApp.Models
{
    public class InssConfig
    {
        public IEnumerable<InssYear> Years { get; set; }
    }


    public class InssYear
    {
        public int Year { get; set; }
        public decimal Celling { get; set; }
        public IEnumerable<Aliquot> Aliquots { get; set; }
    }   

    public class Aliquot
    {
        public decimal MinWage { get; set; }
        public decimal MaxWage { get; set; }
        public decimal Value { get; set; }
    }
}

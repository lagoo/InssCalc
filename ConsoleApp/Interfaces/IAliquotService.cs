using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Interfaces
{
    public interface IAliquotService
    {
        public decimal Aliquot { get; }
        public bool IsLimit { get; }

        public void SetAliquot(int year, decimal wage);
    }
}

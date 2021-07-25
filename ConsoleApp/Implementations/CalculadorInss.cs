using ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Implementations
{
    public class CalculadorInss : ICalculadorInss
    {
        private readonly IAliquotService aliquotService;

        public CalculadorInss(IAliquotService aliquotService)
        {
            this.aliquotService = aliquotService;
        }

        public decimal CalcularDesconto(DateTime data, decimal salario)
        {
            throw new NotImplementedException();
        }
    }
}

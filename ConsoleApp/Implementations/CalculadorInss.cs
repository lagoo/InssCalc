using ConsoleApp.Interfaces;
using System;

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
            if (aliquotService.HasAliquot(data.Year, salario))
                return aliquotService.Celling;

            return (salario * aliquotService.Aliquot) / 100;
        }
    }
}

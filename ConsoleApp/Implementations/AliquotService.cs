using ConsoleApp.Interfaces;
using ConsoleApp.Models;
using Microsoft.Extensions.Options;
using System;
using System.Linq;

namespace ConsoleApp.Implementations
{
    public class AliquotService : IAliquotService
    {
        private readonly InssConfig config;
        private decimal celling { get; set; }
        private decimal aliquot { get; set; }

        public decimal Aliquot => aliquot;
        public decimal Celling => celling;

        public AliquotService(IOptionsSnapshot<InssConfig> optionsSnapshot)
        {
            config = optionsSnapshot.Value;
        }
      
        public bool HasAliquot(int year, decimal wage)
        {
            InssYear yearTable = config.Years.Where(e => e.Year == year).FirstOrDefault();

            if (yearTable == null)
                throw new Exception($"Nenhuma tabela configurada para o ano de {year}");

            celling = yearTable.Celling;
            
            var aliquotSelected = yearTable.Aliquots.Where(e => wage >= e.MinWage && wage <= e.MaxWage).FirstOrDefault();

            if (aliquotSelected != null)
                aliquot = aliquotSelected.Value;

            return aliquotSelected != null;
        }
    }
}

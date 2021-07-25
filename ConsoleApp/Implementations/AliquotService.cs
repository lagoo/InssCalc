using ConsoleApp.Interfaces;
using ConsoleApp.Models;
using Microsoft.Extensions.Options;

namespace ConsoleApp.Implementations
{
    public class AliquotService : IAliquotService
    {
        private readonly InssConfig config;

        public decimal Aliquot => throw new System.NotImplementedException();
        public bool IsLimit => throw new System.NotImplementedException();

        public AliquotService(IOptionsSnapshot<InssConfig> optionsSnapshot)
        {
            config = optionsSnapshot.Value;
        }
        
        public void SetAliquot(int year, decimal wage)
        {
            throw new System.NotImplementedException();
        }
    }
}

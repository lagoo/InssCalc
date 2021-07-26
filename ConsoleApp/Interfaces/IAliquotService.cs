namespace ConsoleApp.Interfaces
{
    public interface IAliquotService
    {
        public decimal Aliquot { get; }
        public decimal Celling { get; }
        public bool HasAliquot(int year, decimal wage);
    }
}

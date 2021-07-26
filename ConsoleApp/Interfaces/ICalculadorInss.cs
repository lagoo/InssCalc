using System;

namespace ConsoleApp.Interfaces
{
    public interface ICalculadorInss
	{
		/// <summary>
		/// Deve retornar o deconto do INSS aplicado ao salário, na determinada data.
		/// </summary>
		decimal CalcularDesconto(DateTime data, decimal salario);
	}
}

using System;

namespace OOP
{
    // Estado e comportamento fazem referencia a uma classe
    public class Pessoa
    {
        // Estado são as representações de uma classe
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }


        // Comportamento é o ato de gerar informação através da própria classe.
        public int CalcularIdade()
        {
            // São metodos que pegam estados de uma classe e processa um comportamento.
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;

            if (dataAtual < DataNascimento.AddYears(idade)) idade--;

            return idade;
        }
    }
}
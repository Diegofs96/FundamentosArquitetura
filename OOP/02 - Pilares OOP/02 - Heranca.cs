using System;

namespace OOP
{
    // Quando falamos de herança podemos usar a expressão "é um(a)".
    // Por exemplo: Um funcionário é uma Pessoa.
    // Classe mãe é sempre a classe que está sendo herdade, no caso Pessoa.
    // Enfatizando: Caso o "é um" não fizer sentido, pode-se significar que essa herança não faz sentido.
    public class Funcionario : Pessoa
    {
        public DateTime DataAdmissao { get; set; }
        public string Registro { get; set; }
    }

    public class Processo
    {
        public void Execucao()
        {
            var funcionario = new Funcionario()
            {
                Nome = "João da Silva",
                DataNascimento = Convert.ToDateTime("1990/01/01"),
                DataAdmissao = DateTime.Now,
                Registro = "0123456",
            };

            funcionario.CalcularIdade();
        }
    }
}
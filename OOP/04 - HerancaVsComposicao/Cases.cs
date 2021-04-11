using System;

namespace OOP
{
    #region Caso 1

    // Relembrando herança: Sempre perguntar se a classe que está herdando "É UM" a classe herdade
    // Aplicando com a visão abaixo: Uma PessoaFisica "É UM (a)" Pessoa?

    // Caso a PessoaFisica possua caracteriscias que não fazem parte de uma Pessoa, significa que está sendo forçado uma herança
    // E caso a classe herdada possua caracteriascas que a classe que está herdando não precisa ter, entra no mesmo contexto anterior.
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
    }


    public class PessoaFisica2
    {
        public Pessoa Pessoa { get; set; }
        public string Cpf { get; set; }
    }


    // A composição funciona da mesma forma que a herança, então nesse Caso 1, ambas as formas fincionarão.
    public class TestesHerancaComposicao
    {
        public TestesHerancaComposicao()
        {
            var pessoaHeranca = new PessoaFisica
            {
                Nome = "Joao",
                DataNascimento = DateTime.Now,
                Cpf = "32165498765"
            };

            var pessoaComposicao = new PessoaFisica2
            {
                Pessoa = new Pessoa
                {
                    Nome = "Joao",
                    DataNascimento = DateTime.Now,
                },
                Cpf = "32165498765"
            };
            // Na herança o valor é manibulado assim.
            var nomeHeranca = pessoaHeranca.Nome;

            // na composição o valor é manipulado da forma abaixo devido ao tipo Pessoa ser instanciado dentro da classe.
            var nomeComposicao = pessoaComposicao.Pessoa.Nome;
        }
    }

    #endregion

    #region Caso 2

    public interface IRepositorio<T>
    {
        void Adicionar(T obj);

        void Excluir(T obj);
    }

    public interface IRepositorioPessoa
    {
        void Adicionar(Pessoa obj);
    }

    public class Repositorio<T> : IRepositorio<T>
    {
        public void Adicionar(T obj)
        {

        }

        public void Excluir(T obj)
        {

        }
    }

    public class RepositorioHerancaPessoa : Repositorio<Pessoa>, IRepositorioPessoa
    {

    }

    public class RepositorioComposicaoPessoa : IRepositorioPessoa
    {
        private readonly IRepositorio<Pessoa> _repositorioPessoa;

        public RepositorioComposicaoPessoa(IRepositorio<Pessoa> repositorioPessoa)
        {
            _repositorioPessoa = repositorioPessoa;
        }

        public void Adicionar(Pessoa obj)
        {
            _repositorioPessoa.Adicionar(obj);
        }
    }

    public class TestesHerancaComposicao2
    {
        public TestesHerancaComposicao2()
        {
            var repoH = new RepositorioHerancaPessoa();
            repoH.Adicionar(new Pessoa());
            repoH.Excluir(new Pessoa());

            var repoC = new RepositorioComposicaoPessoa(new Repositorio<Pessoa>());
            repoC.Adicionar(new Pessoa());
        }
    }

    #endregion
}
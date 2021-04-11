namespace OOP
{
    // Uma interface é uma especie de contrato, ou seja, toda classe que implenta uma interface, é obrigado a implementar os metódos implementados na mesma.
    // OBS: Pode se confundir com classes Abstratas
    // Diferença: Classe abstrata tem que implentar todos os metodos e comportamentos, uma interface só tem que implementar os metodos.
    public interface IRepositorio
    {
        void Adicionar();
    }

    public class Repositorio : IRepositorio
    {
        //public Repositorio(int a)
        //{
            
        //}

        public void Adicionar()
        {
            // Adiciona item
        }
    }

    public class RepositorioFake : IRepositorio
    {
        public void Adicionar()
        {
            // Adiciona item
        }
    }

    public class UsoImplementacao
    {
        public void Processo()
        {
            // Implementação: uso direto dos comportamentos da classe.
            // Problemas nesse caso é que se tiver uma mudança na classe concreta, esse metodos "quebraria"
            var repositorio = new Repositorio();
            repositorio.Adicionar();
        }
    }

    public class UsoAbstracao
    {
        private readonly IRepositorio _repositorio;

        public UsoAbstracao(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Processo()
        {
            _repositorio.Adicionar();
        }
    }

    public class TesteInterfaceImplementacao
    {
        public TesteInterfaceImplementacao()
        {
            var repoImp = new UsoImplementacao();
            repoImp.Processo();

            var repoAbs = new UsoAbstracao(new Repositorio());
            repoAbs.Processo();

            var repoAbsFake = new UsoAbstracao(new RepositorioFake());
            repoAbsFake.Processo();
        }
    }
}

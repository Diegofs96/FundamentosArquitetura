using System;

namespace DemoDI.Cases
{
    public class OperacaoService
    {
        public OperacaoService(
            IOperacaoTransient transient,
            IOperacaoScoped scoped,
            IOperacaoSingleton singleton,
            IOperacaoSingletonInstance singletonInstance)
        {
            // Transient é o modelo padrão e mais comum de usar quando nbão sabe qual modelo usar
            // Aquela dependencia será criado toda vez que aquela dependencia for injetada
            // Consome mais memoria
            Transient = transient;

            // Scoped são criados uma vez por client request
            // Usa sempre o mesmo para não consumir muita memoria
            Scoped = scoped;

            // Singleton cria somente uma unica instancia para toda aplicação
            // quando criado, fica ativo por enquanto a aplicação ficar rodando
            Singleton = singleton;

            SingletonInstance = singletonInstance;
        }

        public IOperacaoTransient Transient { get; }
        public IOperacaoScoped Scoped { get; }
        public IOperacaoSingleton Singleton { get; }
        public IOperacaoSingletonInstance SingletonInstance { get; }
    }

    public class Operacao : IOperacaoTransient,
        IOperacaoScoped,
        IOperacaoSingleton,
        IOperacaoSingletonInstance
    {
        public Operacao() : this(Guid.NewGuid())
        {
        }

        public Operacao(Guid id)
        {
            OperacaoId = id;
        }

        public Guid OperacaoId { get; private set; }
    }

    public interface IOperacao
    {
        Guid OperacaoId { get; }
    }

    public interface IOperacaoTransient : IOperacao
    {
    }

    public interface IOperacaoScoped : IOperacao
    {
    }

    public interface IOperacaoSingleton : IOperacao
    {
    }

    public interface IOperacaoSingletonInstance : IOperacao
    {
    }
}
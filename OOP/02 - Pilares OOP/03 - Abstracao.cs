namespace OOP
{
    // Quando pensar em abstração é que é de oferecer um conjunto de estados e comportamentos que abstrai uma certa especialização.
    // Quando marca uma classe como abstrata, voce diz que essa classe não pode ser instanciada, somente herdada por uma classe que especialize os comportamentos da mesma.
    // O coneito de abstração é a base para o polimorfismo e herança.
    public abstract class Eletrodomestico
    {
        private readonly string _nome;
        private readonly int _voltagem;


        protected Eletrodomestico(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }

        // O abstract siginifica que não é obrigado a implementar o comportamento da classe.
        // Quer dizer que por ele ser um metodo abstrato, a classe que for implementar deverá definir o comportamento dele.
        public abstract void Ligar();
        public abstract void Desligar();

        // Virtual -> Informa que tem um comportamento definido porém possibilita que possa modificar o comportamento.
        // Isso também deixa opcional o uso do comportamento padrão, ou seja, pode implementar da forma que precisar ou não
        public virtual void Testar()
        {
            // teste do equipamento
        }
    }
}
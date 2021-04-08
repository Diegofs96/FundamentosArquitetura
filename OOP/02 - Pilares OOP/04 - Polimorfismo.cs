namespace OOP
{
    // Poli-morfismo
    // Muitos comportamentos em uma classe.
    // Conclusão (minha): Uma classe pode assumir diversos comportamentos independente de ser uma classe herdada
    // Permitindo ter um metodo abstrato
    public class CafeteiraEspressa : Eletrodomestico
    {
        public CafeteiraEspressa(string nome, int voltagem)
            : base(nome, voltagem) { }

        public CafeteiraEspressa()
            : base("Padrao", 220) {  }

        private static void AquecerAgua() { }

        private static void MoerGraos() { }

        public void PrepararCafe()
        {
            Testar();
            AquecerAgua();
            MoerGraos();
            // ETC...
        }

        //Override é a plavra chave do polimosfirmos.
        //Significa que está sobrescrevedo um metodo da classe base (classe Herdada)
        // Está sobrescrevendo o metodo nesse caso porque o Ligar é abstrato e assim obrigado a ser herdada e assim, no caso, tendo que dar outro comportamento.
        public override void Ligar()
        {
            // Verificar recipiente de agua
        }

        public override void Desligar()
        {
            // Resfriar aquecedor
        }

        public override void Testar()
        {
            // teste de cafeteira
        }

    }
}
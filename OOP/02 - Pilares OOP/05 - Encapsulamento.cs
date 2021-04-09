
namespace OOP
{
    // É a arte de escapsular comportamentos através da exposição de métodos públicos e a escrita de métodos privados
    // Encapsulando comportamentos que são privados
    // encapsulamento gira em torno de modificadores
    public class AutomacaoCafe
    {

        public void ServirCafe()
        {
            // encapsular é esconder certos comportamentos que são privados de sua classe, para expor outro que faça uso desses métodos.
            var espresso = new CafeteiraEspressa();
            espresso.Ligar();
            // No caso, é utilizado o Preparar Café para conseguir utilizar os métodos que estão dentro dele.
            espresso.PrepararCafe();
            espresso.Desligar();
        }
    }
}
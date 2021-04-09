using System.Runtime.CompilerServices;

//[assembly: InternalsVisibleTo("ProjetoB")]
namespace ProjetoA
{
    #region Classes

    public class Publica
    {
        public void TestePublico() { }
        private void TestePrivado() { }
        internal void TesteInternal() { }
        protected void TesteProtegido() { }
        private protected void TestePrivadoProtegido() { }
        protected internal void TesteProtegidoInterno() { }
    }

    // Uma classe selada não pode ser herdade, só pode ser instanciada.
    // Está trancada a qualquer forma de extensão
    public sealed class Selada { }

    // Se declarar uma classe sem modificador de acesso, ela já entende que é privada.
    class Privada { }

    internal class Interna { }

    abstract class Abstrata { }

    #endregion
    
    #region Testes

    class TesteClasses
    {
        public TesteClasses()
        {
            var publica = new Publica();
            var privada = new Privada();
            var interna = new Interna();
            //var abstrata = new Abstrata();
        }
    }

    //class TesteSelada : Selada { }

    class TesteModificador1
    {
        public TesteModificador1()
        {
            var publica = new Publica();

            publica.TestePublico();
            publica.TesteInternal();
            publica.TesteProtegidoInterno();
            //publica.TesteProtegido();
            //publica.TestePrivadoProtegido();
            //publica.TestePrivado();
        }
    }

    class TesteModificador2 : Publica
    {
        public TesteModificador2()
        {
            TestePublico();
            TesteInternal();
            TesteProtegido();
            TesteProtegidoInterno();
            TestePrivadoProtegido();
            //TestePrivado();
        }
    }

    #endregion
}

/*******************************************************/
// public:
// Acesso não é restrito
// Access is not restricted.
/*******************************************************/
// protected:
// Acesso é limitado para a classe que contem aquele tipo derivado para outra classe.
// Access is limited to the containing class or types
// derived from the containing class.
/*******************************************************/
// internal:
//O acesso é limitado para o Assembly.
// O internal e private são parecidos.
// Diferença: Quem estiver usando aquela classe dentro do Assembly/dll tem acesso, fora não tem.
// Access is limited to the current assembly.
/*******************************************************/
// protected internal:
// Classes limitados ao assembly ou a classes derivando daquela classe.
// Access is limited to the current assembly or types
// derived from the containing class.
/*******************************************************/
// private:
// O acesso é limitado para aquele tipo. Somente os metodos de uma classe onde foi implementada por usar esse tipo de modificador.
// Access is limited to the containing type.
/*******************************************************/
// private protected:
// O acesso é limitado somente para aquelas classes apenas para as classes que derivam ou se estão dentro do mesmo assembly
// Access is limited to the containing class or types
// derived from the containing class within the current
// assembly.Available since C# 7.2.
/*******************************************************/

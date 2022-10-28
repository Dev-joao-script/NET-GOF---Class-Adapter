using System;

namespace Adapter1
{
    class Program
    {
        static void Main(string[] args)
        {

            var alunosArray = SistemaEscolar.GetListaAlunosMensalidades();

            ICalculaMensalidade calculo = new AlunosAdapter();

            calculo.ProcessaCalculoMensalidade(alunosArray);
            

            Console.ReadKey();
        }
    }
}

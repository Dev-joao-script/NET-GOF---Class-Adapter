using Adapter1.Domain;
using System;
using System.Collections.Generic;

namespace Adapter1
{
    public class AlunosAdapter : ICalculaMensalidade
    {
        private SistemaMensalidades sistemaMensalidades = new SistemaMensalidades();
        public void ProcessaCalculoMensalidade(string[,] alunosArray)
        {
            string Id = null;
            string Nome = null;
            string Mensalidade = null;

            List<Aluno> listaAlunos = new List<Aluno>();

            ConverteArrayParaList(alunosArray, Id, Nome, Mensalidade, listaAlunos);

            sistemaMensalidades.CalculaMensalidade(listaAlunos);
        }

        private void ConverteArrayParaList(string[,] alunosArray, string Id, string Nome,
            string Mensalidade, List<Aluno> listaAlunos)
        {
            for (int i = 0; i < alunosArray.GetLength(0); i++)
            {
                for (int j = 0; j < alunosArray.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Id = alunosArray[i, j];
                    }
                    else if (j == 1)
                    {
                        Nome = alunosArray[i, j];
                    }
                    else
                    {
                        Mensalidade = alunosArray[i, j];
                    }
                }
                //cria a lista de objetos aluno
                listaAlunos.Add(new Aluno(Convert.ToInt32(Id), Nome,
                             Convert.ToDecimal(Mensalidade)));
            }
        }
    }
}

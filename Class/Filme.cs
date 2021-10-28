using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaFilmesSeries
{
    public class Filme : EntidadeBase
    {
        //getters and setters
        private string nomeFilme { get; set; }
        private Genero generoFilme { get; set; }
        private int anoLancamentoFilme { get; set; }
        private float notaFilme { get; set; }
        private string avaliacaoFilme { get; set; }

        //metods
        public Filme(int id, Genero generoFilme, int anoLancamentoFilme, float notaFilme, string avaliacaoFilme)
        {
            this.id = id;
            this.generoFilme = generoFilme;
            this.anoLancamentoFilme = anoLancamentoFilme;
            this.notaFilme = notaFilme;
            this.avaliacaoFilme = avaliacaoFilme;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.generoFilme + Environment.NewLine;
            retorno += "Título: " + this.nomeFilme + Environment.NewLine;
            retorno += "Ano de lançamento: " + this.anoLancamentoFilme + Environment.NewLine;
            retorno += "Nota: " + this.notaFilme + Environment.NewLine;
            retorno += "Avalicação: " + this.avaliacaoFilme + Environment.NewLine;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.nomeFilme;
        }

        public int retornaId()
        {
            return this.id;
        }
    }
}

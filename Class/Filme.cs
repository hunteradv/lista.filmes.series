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
        private string tituloFilme { get; set; }
        private Genero generoFilme { get; set; }
        private int anoLancamentoFilme { get; set; }
        private float notaFilme { get; set; }
        private string avaliacaoFilme { get; set; }
        public bool Excluido { get; set; }

        //metods
        //constructor
        public Filme(int id, string tituloFilme, Genero generoFilme, int anoLancamentoFilme, float notaFilme, string avaliacaoFilme)
        {
            this.id = id;
            this.tituloFilme = tituloFilme;
            this.generoFilme = generoFilme;
            this.anoLancamentoFilme = anoLancamentoFilme;
            this.notaFilme = notaFilme;
            this.avaliacaoFilme = avaliacaoFilme;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.generoFilme + Environment.NewLine;
            retorno += "Título: " + this.tituloFilme + Environment.NewLine;
            retorno += "Ano de lançamento: " + this.anoLancamentoFilme + Environment.NewLine;
            retorno += "Nota: " + this.notaFilme + Environment.NewLine;
            retorno += "Avalicação: " + this.avaliacaoFilme + Environment.NewLine;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.tituloFilme;
        }

        public int retornaId()
        {
            return this.id;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}



using Dio.Series.Enum;

namespace Dio.Series
{
    public class Serie : EntidadeBase
    {
        public Serie(Genero genero, string titulo, string descricao, int ano, string diretor)
        {
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Diretor = diretor;

        }
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private string Diretor { get; set; }
        private bool Excluido {get; set;}

        public override string ToString()
        {
            return "Genero: " + this.Genero + "\n" + "Titulo: " + this.Titulo + "\n" +
                    "Descricao: " + this.Descricao + "\n" + "Ano: " + this.Ano + "\n" +
                    "Diretor: " + this.Diretor;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        internal int retornaId()
        {
            return this.Id;
        }
    }
}
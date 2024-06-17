using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTheFourth.Business.Models
{
    public class Planeta : Entity
    {
        public string Nome { get; set; }
        public string PeriodoDeRotacao { get; set; }
        public string PeriodoOrbital { get; set; }
        public string Diametro { get; set; }
        public string Clima { get; set; }
        public string Gravidade { get; set; }
        public string Terreno { get; set; }
        public string SuperficieDaAgua { get; set; }
        public string Populacao { get; set; }
        public IEnumerable<Personagem> Moradores { get; set; }
        public IEnumerable<Filme> Filmes { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataEdicao { get; set; }
        public string url { get; set; }
    }
}

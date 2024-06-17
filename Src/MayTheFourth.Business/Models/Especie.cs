using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTheFourth.Business.Models
{
    public class Especie : Entity
    {
        public string Nome { get; set; }
        public string Classificacao { get; set; }
        public string Designacao { get; set; }
        public string AlturaMedia { get; set; }
        public string CoresDaPele { get; set; }
        public string CoresDoCabelo { get; set; }
        public string CoresDosOlhos { get; set; }
        public string ExpectativaDeVidaMedia { get; set; }
        public Planeta PlanetaNatal { get; set; }
        public string Linguagem { get; set; }
        public IEnumerable<Personagem> Pessoas { get; set; }
        public IEnumerable<Filme> films { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataEdicao { get; set; }
        public string Url { get; set; }
    }
}

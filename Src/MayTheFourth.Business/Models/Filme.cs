using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTheFourth.Business.Models
{
    public class Filme : Entity
    {
        public string? Titulo { get; set; }
        public string? Episodio { get; set; }
        public string? Sinopse { get; set; }
        public string? Diretor { get; set; }
        public string? Produtora { get; set; }
        public string? DataLancamento { get; set; }
        public IEnumerable<Personagem>? Personagens { get; set; }
        public IEnumerable<Planeta>? Planetas { get; set; }
        public IEnumerable<NaveEstrelar>? NavesEstrelares { get; set; }
        public IEnumerable<Veiculo> Veiculos { get; set; }
        public IEnumerable<Especie>? Especies { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataEdicao { get; set; }
        public string? Url { get; set; }
    }
}

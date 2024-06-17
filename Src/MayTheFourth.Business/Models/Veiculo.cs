using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTheFourth.Business.Models
{
    public class Veiculo : Entity
    {
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public string Fabricante { get; set; }
        public Decimal Valor { get; set; }
        public string Tamanho { get; set; }
        public string VelocidaMaxima { get; set; }
        public string Equipe { get; set; }
        public string Passageiros { get; set; }
        public string CapacidadeDeCarga { get; set; }
        public string Consumiveis { get; set; }
        public string ClassDeVeiculo { get; set; }
        public IEnumerable<Personagem> Pilotos { get; set; }
        public IEnumerable<Filme> Filmes { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataEdicao { get; set; }
        public string url { get; set; }
    }
}

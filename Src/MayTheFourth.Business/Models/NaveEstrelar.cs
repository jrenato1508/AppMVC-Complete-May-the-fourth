using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTheFourth.Business.Models
{
    public class NaveEstrelar : Entity
    {
        public string? Nome { get; set; }
        public string? Model { get; set; }
        public string? Fabricante { get; set; }
        public decimal Valor { get; set; }
        public string? Comprimento { get; set; }
        public string? VelocidadeMaxima { get; set; }
        public string? Equipe { get; set; }
        public string? Passageiros { get; set; }
        public string? CapacidadeDeCarga { get; set; }
        public string? Consumiveis { get; set; }
        public string? ClassificacaoDeHiperdrive { get; set; }
        public string? MGLT { get; set; }
        public string? ClasseDeNaveStelar { get; set; }
        public IEnumerable<Personagem>? Pilotos { get; set; }
        public IEnumerable<Filme>? Filmes { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataEdicao { get; set; }
        public string? Url { get; set; }
    }

   
}

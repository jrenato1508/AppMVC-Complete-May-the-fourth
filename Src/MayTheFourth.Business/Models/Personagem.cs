using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTheFourth.Business.Models
{
    public class Personagem : Entity
    {
        public string? Nome { get; set; }
        public string? Altura { get; set; }
        public string? Peso { get; set; }
        public string? CorDoCabelo { get; set; }
        public string? CorDaPele { get; set; }
        public string? CorDosOlhos { get; set; }
        public string? DataAniversario { get; set; }
        public Sexo Sexo { get; set; }
        public string? PlanetaNatal { get; set; }
        public IEnumerable<Filme> Filmes { get; set; }
        public Especie Especies { get; set; }
        public IEnumerable<Veiculo> Veiculos { get; set; }
        public IEnumerable<NaveEstrelar>? NavesEstrelares { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataEdicao { get; set; }
        public string? url { get; set; }
    }
    public enum Sexo
    {
        Masculio = 1,
        Feminino,
        Desconhecido
    }
}

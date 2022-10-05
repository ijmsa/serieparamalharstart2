using SerieParaMalharStart.VoeAirlines.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.VoeAirlines.Entities
{
    internal class Aeronave
    {
        public string Modelo;
        public string Fabricante;
        public decimal ValorAprox;
        public TipoAeronave Tipo;
        public DateTime DataFabricacao;
        public string Matricula;
        public string LocalFabricacao;
        public decimal Envergadura;
        public decimal Comprimento;
        public decimal Altura;
        public int Capacidade;
        public double VelocidadeMax;
        public double VelocidadeCruzeiro;
        public double AltitudeCruzeiro;
        public string Codigo;
        public Celebridade celebridade;
    }
}

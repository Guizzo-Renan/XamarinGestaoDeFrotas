using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace projetoFrota.Model
{
    public class Veiculo
    {
        private string placa;
        private string fabricante;
        private string modelo;
        private string cor;
        private int ano;
        [PrimaryKey]
        public string Placa { get => placa; set => placa = value; }
        public string Fabricante { get => fabricante; set => fabricante = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Cor { get => cor; set => cor = value; }
        public int Ano { get => ano; set => ano = value; }
       // public virtual List<Abastecimento> Abastecimentos { get; set; }

    }
}

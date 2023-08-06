using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace projetoFrota.Model
{
    public class Abastecimento
    {
        private long id;
        private DateTime data;
        private Veiculo automovel;
        private string veiculoPlaca;
        private Combustivel tipoCombustivel;
        private long tipoCombustivelId;
        private decimal litros;
        private long km;
        private decimal precoLitro;

        [PrimaryKey,AutoIncrement]
        public long Id { get => id; set => id = value; }
        public DateTime Data { get => data; set => data = value; }
        [ManyToOne]
        public virtual Veiculo Automovel
        {
            get => automovel;
            set { automovel = value;
                    if (automovel.Placa != null && veiculoPlaca == null){
                    //    this.veiculoPlaca = automovel.Placa;
                    }                    
            }                
        }
        [ForeignKey(typeof(Veiculo))]
        public string VeiculoPlaca
        {
            get => veiculoPlaca; set
            {
                veiculoPlaca = value;
                if (veiculoPlaca != null && automovel == null)
                {
                 //   Automovel = App._Banco.UmVeiculo(veiculoPlaca).Result;
                }
            }
        }

        [ManyToOne]
        public virtual Combustivel TipoCombustivel { get => tipoCombustivel;
            set { tipoCombustivel = value;
                    if(tipoCombustivel.Id != 0 && TipoCombustivelId == 0)
                    {
                      // this.TipoCombustivelId = tipoCombustivel.Id;
                    }
                }
        }
        [ForeignKey(typeof(Combustivel))]
        public long TipoCombustivelId { get => tipoCombustivelId; set => tipoCombustivelId = value; }

        public decimal Litros { get => litros; set => litros = value; }
        public long Km { get => km; set => km = value; }
        public decimal PrecoLitro { get => precoLitro; set => precoLitro = value; }
        
    }
}

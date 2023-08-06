using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace projetoFrota.Model
{
    public class Combustivel
    {
        private long id;
        private string nome;
        private decimal valor;

        [PrimaryKey,AutoIncrement]
        public long Id { get => id; set => id = value; }

        [Unique]
        [NotNull]
        public string Nome
        {
            get => nome; set
            {
                if (value != null & value != "")
                {
                    var aux = value[0].ToString().ToUpper() + value.Substring(1).ToLower();
                    nome = aux;
                }
                else { nome = value; }
            }
        }
        public decimal Valor { get => valor; set => valor = value; }
        
        //[OneToMany(CascadeOperations=CascadeOperation.All)]
        //public virtual List<Abastecimento> ListaAbastecimentos { get; set; }
    }
}

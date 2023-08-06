using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace projetoFrota.Model
{
    public class Constantes
    {
        public const string NomeBancoDeDados = "FrotaDB.db3";

        public const SQLite.SQLiteOpenFlags Flags =
            // abre o banco em modo leitura e gravação
            SQLite.SQLiteOpenFlags.ReadWrite |
            // Cria o banco se não existir
            SQLite.SQLiteOpenFlags.Create |
            // permite mutiplos acessos 
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath
        {
            get
            {
                var caminho = Environment.GetFolderPath(
                         Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(caminho, NomeBancoDeDados);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicicleta
{
    public class Bicicleta
    {
        #region Propriedades
        public int id { get; set; }
        public string Modelo { get; set; }
        public Fabricante Fabricante { get; set; }
        public DateTime DataFabricacao { get; set; }
        #endregion


        public override string ToString()
        {
            return "id Bicicleta: " +this.id+
                    "\nModelo: "+this.Modelo+
                    "\nFabricante"+this.Fabricante.Nome+
                    "\nData de Fabricação: "+this.DataFabricacao;
        }
    }
}

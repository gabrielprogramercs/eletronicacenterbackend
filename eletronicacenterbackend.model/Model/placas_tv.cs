using eletronicacenterbackend.model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eletronicacenterbackend.model.Model
{
    public class placas_tv
    {
        public string codigo_fabricante { get; set; }
        public string compatibilidade_modelo_tv { get; set; }
        public DateTime datadeutilizacao { get; set; }
        public DateTime datadocadastro { get; set; }
        public int estoque { get; set; }
        public int id_placa { get; set; }
        public int idmarca { get; set; }
        public string modelo { get; set; }
        public decimal preco { get; set; }
        public string tipo { get; set; }
    }
}

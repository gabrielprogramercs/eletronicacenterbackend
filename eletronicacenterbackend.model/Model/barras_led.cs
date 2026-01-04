using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eletronicacenterbackend.model.Model
{
    public class barras_led
    {
        public int id_barra { get; set; }
        public string modelo { get; set; }
        public decimal comprimento_cm { get; set; }
        public int quantidade_leds { get; set; }

        public string codigo_fabricante { get; set; }
        public string compatibilidade_modelo_tv { get; set; }
        public decimal preco { get; set; }

        public int estoque { get; set; }


        public int id_marca { get; set; }
        public DateTime datadeutilizacao { get; set; }
        public DateTime datadocadastro { get; set; }


    }
}

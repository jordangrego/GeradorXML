using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeradorXML.Entidades
{
    public class MensagemInicial
    {
        public String DataGeracaoArquivo { get; set; }
        public List<Ficha> ListaFichas { get; set; }

        public MensagemInicial()
        {
            this.ListaFichas = new List<Ficha>();
        }

    }
}

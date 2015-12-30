using System;
using System.IO;
using System.Xml.Serialization;
using GeradorXML.Entidades;

namespace GeradorXML.Util
{
    public static class UtilGeradorXML
    {
        public static MensagemInicial RecuperaImportacao(String pathArquivo)
        {
            MensagemInicial importacaoFichas = new MensagemInicial();
            XmlSerializer x = new XmlSerializer(importacaoFichas.GetType());
            StreamReader leitor = new StreamReader(pathArquivo);
            importacaoFichas = (MensagemInicial)x.Deserialize(leitor);
            leitor.Close();
            return importacaoFichas;
        }

        public static void GravaLista(MensagemInicial importacaoFichas, String pathArquivo)
        {
            XmlSerializer x = new XmlSerializer(importacaoFichas.GetType());
            StreamWriter escritor = new StreamWriter(pathArquivo + "\\ArquivoModelo.xml");
            x.Serialize(escritor, importacaoFichas);
            escritor.Close();
        }
    }
}

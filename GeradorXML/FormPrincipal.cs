using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GeradorXML.Util;
using GeradorXML.Entidades;

namespace GeradorXML
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnGerarXML_Click(object sender, EventArgs e)
        {
            try
            {
                // chama pasta local
                DialogoPasta.ShowDialog();
                String pathArquivo = DialogoPasta.SelectedPath;
                if (pathArquivo.Equals(String.Empty))
                {
                    throw new Exception("Caminho da pasta Inválido!");
                }


                //List<Ficha> listaFicha = new List<Ficha>();
                //listaFicha.Add(geraFicha());
                //listaFicha.Add(geraFicha());

                //List<Ficha> listaFiltrada = listaFicha.FindAll(f => f.ListaAeronaves.Where(a => a.AnoFabricacao.Contains("2014")).Count > 0).ToList<Ficha>();



                UtilGeradorXML.GravaLista(geraLista(), pathArquivo);
                MessageBox.Show("Arquivo XML gerado com Sucesso", "Arquivo XML Gerado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("A Aplicação gerou um erro:\nMessagem:\n" + ex.Message + "\nStackTrace:\n" + ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private MensagemInicial geraLista()
        {
            MensagemInicial arquivo = new MensagemInicial();
            arquivo.DataGeracaoArquivo = DateTime.Now.ToString("G");

            arquivo.ListaFichas.Add(geraFicha());
            //arquivo.ListaFichas.Add(geraFicha());
            return arquivo;
        }

        public Ficha geraFicha()
        {
            Ficha ficha = new Ficha();
            ficha.NumeroOcorrencia = 12345678;
            ficha.ClassificacaoOcorrencia = "Class. Exemplo";
            ficha.ComandoInvestigador = "Comando Exemplo";
            ficha.DataOcorrencia = DateTime.Now.ToString("dd/MM/yyyy");
            ficha.DataAutenticacao = DateTime.Now.ToString("dd/MM/yyyy");
            ficha.DataConfirmacao = DateTime.Now.ToString("dd/MM/yyyy");
            ficha.DataEmissao = DateTime.Now.ToString("dd/MM/yyyy");
            ficha.CaracteristicasLocalDificuldades = "Desc Exemplo";
            ficha.EmailAutenticacao = "email@mail.com";
            ficha.EmailConfirmacao = "email@mail.com";
            ficha.EmailEmissao = "email@mail.com";
            ficha.FaseOperacao = "Fase Exemplo";
            ficha.FaxAutenticacao = "12345678";
            ficha.FaxConfirmacao = "12345678";
            ficha.FaxEmissao = "12345678";
            ficha.Historico = "Hist. Exemplo";
            ficha.HoraOcorrencia = "00:00";
            ficha.HoraUTC = "00:00";
            ficha.Localidade = "12345678";
            ficha.TipoCoordenada = "DMS";
            ficha.LatitudeDMS = new LatitudeDMS()
            {
                GrauLatitude = 10,
                MinutoLatitude = 10,
                SegundoLatitude = 10,
                LatitudeNS = "N"
            };
            ficha.LongitudeDMS = new LongitudeDMS()
            {
                GrauLongitude = 10,
                MinutoLongitude = 10,
                SegundoLongitude = 10,
                LongitudeWE = "W"
            };
            ficha.LatitudeGraus = "12345678";
            ficha.LongitudeGraus = "12345678";
            ficha.NomeAutenticacao = "Pedro";
            ficha.NomeConfirmacao = "Thiago";
            ficha.NomeEmissao = "Mateus";
            ficha.NumeroOcorrencia = 12345678;
            ficha.Observacoes = "Obs. Exemplo";
            ficha.TelefoneAutenticacao1 = "12345678";
            ficha.TelefoneAutenticacao2 = "12345678";
            ficha.TelefoneConfirmacao1 = "12345678";
            ficha.TelefoneConfirmacao2 = "12345678";
            ficha.TelefoneEmissao1 = "12345678";
            ficha.TelefoneEmissao2 = "12345678";
            ficha.TipoOcorrencia = "12345678";
            ficha.UF = "DF";
            ficha.Municipio = "Cidade do Ocorrído";

            ficha.CelularInvestigador = 123456;
            ficha.EmailInvestigador = "email@email.com";
            ficha.FaxInvestigador = 123456;
            ficha.NomeInvestigador = "João Exemplo";
            ficha.NumCredencialInvestigador = "313213265";

            ficha.ListaAeronaves.Add(geraAeronave1());
            ficha.ListaAeronaves.Add(geraAeronave2());

            ficha.ObservacaoProvidencias = "Observações Providências";
            ficha.ProvidenciasAcaoInicial = true;
            ficha.ProvidenciasOutras = false;

            return ficha;
        }
    
        private Aeronave geraAeronave1(){
            Aeronave aeronave = new Aeronave();
            //definições voo
            aeronave.TipoAerodromoOrigem = "FORA AERODROMO";
            aeronave.AerodromoUltimaDecolagem = "";
            aeronave.CodIATADecolagem = 0;
            aeronave.CodICAODecolagem = 0;


            aeronave.TipoAerodromoDestino = "BRASILEIRO";
            aeronave.AerodromoPousoPretendido = "GUARULHOS";
            aeronave.CodIATAPouso = 123456;
            aeronave.CodICAOPouso = 654321;


            aeronave.AnoFabricacao = "2014";
            aeronave.CargasPerigosas = "Cargas Teste";

            aeronave.DanosAeronave = "Dados Exemplo";
            aeronave.DescricaoSucinta = "Descrição Sucinta";
            aeronave.Equipamento = "Equip Exemplo";
            aeronave.EstadoRegistro = "DF";
            aeronave.Fabricante = "Fab Exemplo";
            aeronave.MatriculaAeronave = "12221452";
            aeronave.Modelo = "PPG110000";
            aeronave.MatriculaNacionalEstrangeira = "NACIONAL";
            aeronave.NumPassageirosDesconhecido = 10;
            aeronave.NumPassageirosFatal = 10;
            aeronave.NumPassageirosGrave = 10;
            aeronave.NumPassageirosIleso = 10;
            aeronave.NumPassageirosLeve = 10;
            aeronave.NumSerie = "999999";
            aeronave.Modelo = "Modelo Exemplo";
            aeronave.NumTerceirosDesconhecido = 10;
            aeronave.NumTerceirosFatal = 10;
            aeronave.NumTerceirosGrave = 10;
            aeronave.NumTerceirosLeve = 10;
            aeronave.NumTripulantesDesconhecido = 10;
            aeronave.NumTripulantesFatal = 10;
            aeronave.NumTripulantesGrave = 10;
            aeronave.NumTripulantesIleso = 10;
            aeronave.NumTripulantesLeve = 10;
            aeronave.Operacao = "Oper Exemplo";
            aeronave.OutrasCargas = "Outras Cargas Exemplo";
            aeronave.PesoMaxDEP = "PesoMaxDEP";
            aeronave.POBPassageiros = 10;
            aeronave.POBTotal = 10;
            aeronave.POBTripulantes = 10;
            aeronave.ProprietarioOperador = "Proprietario Exemplo";
            aeronave.Registro = "Reg Exemplo";

            aeronave.ListaTripulantes = geraTripulantoAeronave1();
            return aeronave;
        }

        private Aeronave geraAeronave2(){
            Aeronave aeronave = new Aeronave();

            //definições voo
            aeronave.TipoAerodromoOrigem = "BRASILEIRO";
            aeronave.AerodromoUltimaDecolagem = "CONGONHAS";
            aeronave.CodIATADecolagem = 123456;
            aeronave.CodICAODecolagem = 654321;

            aeronave.TipoAerodromoDestino = "BRASILEIRO";
            aeronave.AerodromoPousoPretendido = "GUARULHOS";
            aeronave.CodIATAPouso = 123456;
            aeronave.CodICAOPouso = 654321;

            aeronave.AnoFabricacao = "2014";
            aeronave.CargasPerigosas = "Cargas Teste";
            aeronave.DanosAeronave = "Dados Exemplo";
            aeronave.DescricaoSucinta = "Descrição Sucinta";
            aeronave.Equipamento = "Equip Exemplo";
            aeronave.EstadoRegistro = "DF";
            aeronave.Fabricante = "Fab Exemplo";
            aeronave.MatriculaAeronave = "12221452";
            aeronave.Modelo = "PPG110000";
            aeronave.MatriculaNacionalEstrangeira = "S";
            aeronave.NumPassageirosDesconhecido = 10;
            aeronave.NumPassageirosFatal = 10;
            aeronave.NumPassageirosGrave = 10;
            aeronave.NumPassageirosIleso = 10;
            aeronave.NumPassageirosLeve = 10;
            aeronave.NumSerie = "999999";
            aeronave.Modelo = "Modelo Exemplo";
            aeronave.NumTerceirosDesconhecido = 10;
            aeronave.NumTerceirosFatal = 10;
            aeronave.NumTerceirosGrave = 10;
            aeronave.NumTerceirosLeve = 10;
            aeronave.NumTripulantesDesconhecido = 10;
            aeronave.NumTripulantesFatal = 10;
            aeronave.NumTripulantesGrave = 10;
            aeronave.NumTripulantesIleso = 10;
            aeronave.NumTripulantesLeve = 10;
            aeronave.Operacao = "Oper Exemplo";
            aeronave.OutrasCargas = "Outras Cargas Exemplo";
            aeronave.PesoMaxDEP = "PesoMaxDEP";
            aeronave.POBPassageiros = 10;
            aeronave.POBTotal = 10;
            aeronave.POBTripulantes = 10;
            aeronave.ProprietarioOperador = "Proprietario Exemplo";
            aeronave.Registro = "Reg Exemplo";

            aeronave.ListaTripulantes = geraTripulantoAeronave2();
            return aeronave;
        }

        private List<Tripulante> geraTripulantoAeronave1()
        {
            List<Tripulante> lista = new List<Tripulante>();

            Tripulante trip = new Tripulante();

            trip.CodANAC = "9879879";
            trip.Nacionalidade = "BRA";
            trip.Nome = "Mateus";
            trip.Cargo = "Trip";

            Tripulante trip2 = new Tripulante();

            trip2.CodANAC = "9879879";
            trip2.Nacionalidade = "BRA";
            trip2.Nome = "João";
            trip2.Cargo = "Trip";

            lista.Add(trip);
            lista.Add(trip2);
            return lista;
        }

        private List<Tripulante> geraTripulantoAeronave2()
        {
            List<Tripulante> lista = new List<Tripulante>();

            Tripulante trip = new Tripulante();

            trip.CodANAC = "9879879";
            trip.Nacionalidade = "BRA";
            trip.Nome = "Thiago";
            trip.Cargo = "Trip";

            Tripulante trip2 = new Tripulante();

            trip2.CodANAC = "9879879";
            trip2.Nacionalidade = "BRA";
            trip2.Nome = "Pedro";
            trip2.Cargo = "Trip";

            lista.Add(trip);
            lista.Add(trip2);
            return lista;
        }
    }


}

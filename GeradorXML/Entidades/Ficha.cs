using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeradorXML.Entidades
{
    public class Ficha
    {
        public List<Aeronave> ListaAeronaves { get; set; }
        
        public Int32 NumeroOcorrencia { get; set; }	//Sim	8	Numérico	NNNN/NNNN
        public String ClassificacaoOcorrencia { get; set; }	//	Sim	25	Alfanumérico	
        public String DataOcorrencia { get; set; }	//	Não	10	Alfanumérico	DD/MM/AAA
        public String HoraOcorrencia { get; set; }	//	Não	8	Alfanumérico	HH:MM
        public String HoraUTC { get; set; }	//	Não	8	Alfanumérico	HH:MM
        public String TipoCoordenada { get; set; } // Campo que define qual tipo de unidade de latitude e longitude foi passado
        public LatitudeDMS LatitudeDMS { get; set; }	// (em DMS)	Não	7	Alfanumérico	
        public LongitudeDMS LongitudeDMS { get; set; }	// (em DMS)	Não	7	Alfanumérico	
        public String LatitudeGraus { get; set; }	// (em Graus decimais)	Não	6	Alfanumérico	
        public String LongitudeGraus { get; set; }	// (em Graus Decimais)	Não	6	Alfanumérico	
        public String Localidade { get; set; }	//	Não	30	Alfanumérico	
        public String Municipio { get; set; }	//	Não	30	Alfanumérico	
        public String UF { get; set; }	//	Não	2	Alfanumérico	
        public String Historico { get; set; }	//	Não	2000	Alfanumérico
        public String FaseOperacao { get; set; }	//	Não	35	Alfanumérico
        public String TipoOcorrencia { get; set; }	//	Não	50	Alfanumérico	
        public String CaracteristicasLocalDificuldades { get; set; }	// (Característica do Local e Dificuldades) 	Não	350	Alfanumérico
        public String ComandoInvestigador { get; set; }	//	Não	10	Alfanumérico
        public String Observacoes { get; set; }	// 	Não	350	Alfanumérico
        // Emitido por:
        public String DataEmissao { get; set; }	//	Não	10	Numérico	DD/MM/AAA
        public String NomeEmissao { get; set; }	//	Não	50	Alfanumérico	
        public String TelefoneEmissao1 { get; set; }	//	Não	15	Numérico	NNNNNNNNNN
        public String TelefoneEmissao2 { get; set; }	//	Não	15	Numérico	NNNNNNNNNN
        public String FaxEmissao { get; set; }	//	Não	15	Numérico	NNNNNNNNNN
        public String EmailEmissao { get; set; }	//	Não	50	Alfanumérico	
        // Confirmado por:
        public String DataConfirmacao { get; set; }	//	Não	10	Numérico	DD/MM/AAA
        public String NomeConfirmacao { get; set; }	//	Não	50	Alfanumérico	
        public String TelefoneConfirmacao1 { get; set; }	//	Não	15	Numérico	NNNNNNNNNN
        public String TelefoneConfirmacao2 { get; set; }	//	Não	15	Numérico	NNNNNNNNNN
        public String FaxConfirmacao { get; set; }	//	Não	15	Numérico	NNNNNNNNNN
        public String EmailConfirmacao { get; set; }	//	Não	50	Alfanumérico	
        // Autenticado por:
        public String DataAutenticacao { get; set; }	//	Não	10	Numérico	DD/MM/AAA
        public String NomeAutenticacao { get; set; }	//	Não	50	Alfanumérico	
        public String TelefoneAutenticacao1 { get; set; }	//	Não	15	Numérico	NNNNNNNNNN
        public String TelefoneAutenticacao2 { get; set; }	//	Não	15	Numérico	NNNNNNNNNN
        public String FaxAutenticacao { get; set; }	//	Não	15	Numérico	NNNNNNNNNN
        public String EmailAutenticacao { get; set; }	//	Não	50	Alfanumérico	

        //Investigador
        public String NomeInvestigador { get; set; }	//	Não	50	Alfanumérico
        public String EmailInvestigador { get; set; }	//	Não	50	Alfanumérico
        public String NumCredencialInvestigador { get; set; }	//	Não	10	Numérico
        public Int32 TelefoneInvestigador { get; set; }	//	Não	15	Numérico
        public Int32 CelularInvestigador { get; set; }	//	Não	15	Numérico
        public Int32 FaxInvestigador { get; set; }	//	Não	15	Numérico

        //Providencias
        public String ObservacaoProvidencias { get; set; }	//	Não	500	Alfanumérico
        public Boolean ProvidenciasAcaoInicial { get; set; }
        public Boolean ProvidenciasOutras { get; set; }

        public Ficha()
        {
            this.ListaAeronaves = new List<Aeronave>();
        }
    }
}

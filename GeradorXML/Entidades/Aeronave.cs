using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeradorXML.Entidades
{
    public class Aeronave
    {

        public List<Tripulante> ListaTripulantes { get; set; }

        public Aeronave()
        {
            this.ListaTripulantes = new List<Tripulante>();
        }

        public String MatriculaAeronave { get; set; }
        public String MatriculaNacionalEstrangeira { get; set; }	// (Aeronave)	Não	5	Alfanumérico	
        public String EstadoRegistro { get; set; }	//	Não	30	Alfanumérico	
        public String Equipamento { get; set; }	//	Não	40	Alfanumérico	
        public String Fabricante { get; set; }	//	Não	40	Alfanumérico	
        public String Modelo { get; set; }	//	Não	30	Alfanumérico	
        public String NumSerie { get; set; }	//	Não	30	Alfanumérico	
        public String AnoFabricacao { get; set; }	//	Não	4	Numérico	
        public String PesoMaxDEP { get; set; }	//	Não	20	Alfanumérico	
        public String ProprietarioOperador { get; set; }	// /Operador	Não	256	Alfanumérico	
        public String Operacao { get; set; }	//	Não	50	Alfanumérico	
        public String Registro { get; set; }	//	Não	30	Alfanumérico	

        // Definições
        public String TipoAerodromoOrigem { get; set; }
        //	Substitudo o campo requisitado  LocalUltimaDecolagem
        public String AerodromoUltimaDecolagem { get; set; }	//	Não	30	Alfanumérico	
        public int CodIATADecolagem { get; set; }
        public int CodICAODecolagem { get; set; }

        public String TipoAerodromoDestino { get; set; }
        public String AerodromoPousoPretendido { get; set; }	//	Não	30	Alfanumérico	
        public int CodIATAPouso { get; set; }
        public int CodICAOPouso { get; set; }

        public Int32 POBTripulantes { get; set; }	// (Nº de Pessoas a bordo)	Não	3	Numérico
        public Int32 POBPassageiros { get; set; }	// (Nº de Pessoas a bordo)	Não	3	Numérico
        public Int32 POBTotal { get; set; }	// (Nº de Pessoas a bordo)	Não	3	Numérico

        //* tripulantes
        public Int32 NumTripulantesIleso { get; set; }	//(Nº de Tripulantes ilesos)	Não	3	Numérico
        public Int32 NumTripulantesLeve { get; set; }	//(Nº de Tripulantes com lesão leve)	Não	3	Numérico
        public Int32 NumTripulantesGrave { get; set; }	//(Nº de Tripulantes com lesão grave)	Não	3	Numérico
        public Int32 NumTripulantesFatal { get; set; }	//(Nº de Tripulantes fatais)	Não	3	Numérico
        public Int32 NumTripulantesDesconhecido { get; set; }	//(Nº de Tripulantes desconhecidos)	Não	3	Numérico

        //* Passageiros
        public Int32 NumPassageirosIleso { get; set; }	//(Nº de  Passageiros  ilesos)	Não	3	Numérico
        public Int32 NumPassageirosLeve { get; set; }	//(Nº de  Passageiros  com lesão leve)	Não	3	Numérico
        public Int32 NumPassageirosGrave { get; set; }	//(Nº de  Passageiros  com lesão grave)	Não	3	Numérico
        public Int32 NumPassageirosFatal { get; set; }	//(Nº de  Passageiros fatais)	Não	3	Numérico
        public Int32 NumPassageirosDesconhecido { get; set; }	// (Nº de Passageiros desconhecidos)	Não	3	Numérico

        //* Terceiros
        public Int32 NumTerceirosLeve { get; set; }	// (Nº de Terceiros com lesão leve)	Não	3	Numérico
        public Int32 NumTerceirosGrave { get; set; }	// (Nº de Terceiros com lesão grave)	Não	3	Numérico
        public Int32 NumTerceirosFatal { get; set; }	//(Nº de Terceiros fatais)	Não	3	Numérico
        public Int32 NumTerceirosDesconhecido { get; set; }	// (Nº de Terceiros desconhecidos)	Não	3	Numérico
        
        public String DanosAeronave { get; set; }	//	Não	11	Alfanumérico
        public String DescricaoSucinta { get; set; }	//	Não	1500	Alfanumérico
        

        public String CargasPerigosas { get; set; }	//	Não	10	Alfanumérico
        public String OutrasCargas { get; set; }	//	Não	10	Alfanumérico



    }
}

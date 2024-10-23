using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntegracaoEntity.DiagnosticosBrasil
{
    public class DadosRespostaEnviaLaudoAtendimentoDBViewModel
    {
        private string numeroAtendimentoApoiadoField;

        private string numeroAtendimentoDBField;

        private string rGPacienteApoiadoField;

        private string rGPacienteDBField;

        private string nomePacienteField;

        private string sexoField;

        private double pesoField;

        private double alturaField;

        private string numeroCPFField;

        private System.DateTime dataNascimentoField;

        private ResultadoProcedimentosV2[] listaResultadoProcedimentosField;

        private string usoApoiadoField;

        /// <remarks/>
        public string NumeroAtendimentoApoiado
        {
            get
            {
                return this.numeroAtendimentoApoiadoField;
            }
            set
            {
                this.numeroAtendimentoApoiadoField = value;
            }
        }

        /// <remarks/>
        public string NumeroAtendimentoDB
        {
            get
            {
                return this.numeroAtendimentoDBField;
            }
            set
            {
                this.numeroAtendimentoDBField = value;
            }
        }

        /// <remarks/>
        public string RGPacienteApoiado
        {
            get
            {
                return this.rGPacienteApoiadoField;
            }
            set
            {
                this.rGPacienteApoiadoField = value;
            }
        }

        /// <remarks/>
        public string RGPacienteDB
        {
            get
            {
                return this.rGPacienteDBField;
            }
            set
            {
                this.rGPacienteDBField = value;
            }
        }

        /// <remarks/>
        public string NomePaciente
        {
            get
            {
                return this.nomePacienteField;
            }
            set
            {
                this.nomePacienteField = value;
            }
        }

        /// <remarks/>
        public string Sexo
        {
            get
            {
                return this.sexoField;
            }
            set
            {
                this.sexoField = value;
            }
        }

        public double Peso
        {
            get
            {
                return this.pesoField;
            }
            set
            {
                this.pesoField = value;
            }
        }

        public double Altura
        {
            get
            {
                return this.alturaField;
            }
            set
            {
                this.alturaField = value;
            }
        }

        public string NumeroCPF
        {
            get
            {
                return this.numeroCPFField;
            }
            set
            {
                this.numeroCPFField = value;
            }
        }

        public System.DateTime DataNascimento
        {
            get
            {
                return this.dataNascimentoField;
            }
            set
            {
                this.dataNascimentoField = value;
            }
        }

        public ResultadoProcedimentosV2[] ListaResultadoProcedimentos
        {
            get
            {
                return this.listaResultadoProcedimentosField;
            }
            set
            {
                this.listaResultadoProcedimentosField = value;
            }
        }

        public string UsoApoiado
        {
            get
            {
                return this.usoApoiadoField;
            }
            set
            {
                this.usoApoiadoField = value;
            }
        }
    }

    public partial class ResultadoProcedimentos
    {
        private string descricaoMetodologiaField;

        private string descricaoRegiaoColetaField;

        private ResultadoTexto[] listaResultadoTextoField;

        private ResultadoImagem[] listaResultadoImagemField;

        private System.DateTime dataHoraLiberacaoClinicaField;

        private string nomeLiberadorClinicoField;

        private string observacao1Field;

        private string observacao2Field;

        private string observacao3Field;

        private string observacao4Field;

        private string observacao5Field;

        private string materialField;

        private string identificacaoExameApoiadoField;

        private string materialApoiadoField;

        private string descricaoMaterialApoiadoField;

        private string descricaoExameApoiadoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string CodigoExameDB { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string VersaoLaudo { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string DescricaoMetodologia
        {
            get
            {
                return this.descricaoMetodologiaField;
            }
            set
            {
                this.descricaoMetodologiaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string DescricaoRegiaoColeta
        {
            get
            {
                return this.descricaoRegiaoColetaField;
            }
            set
            {
                this.descricaoRegiaoColetaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 4)]
        public ResultadoTexto[] ListaResultadoTexto
        {
            get
            {
                return this.listaResultadoTextoField;
            }
            set
            {
                this.listaResultadoTextoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 5)]
        public ResultadoImagem[] ListaResultadoImagem
        {
            get
            {
                return this.listaResultadoImagemField;
            }
            set
            {
                this.listaResultadoImagemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public System.DateTime DataHoraLiberacaoClinica
        {
            get
            {
                return this.dataHoraLiberacaoClinicaField;
            }
            set
            {
                this.dataHoraLiberacaoClinicaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string NomeLiberadorClinico
        {
            get
            {
                return this.nomeLiberadorClinicoField;
            }
            set
            {
                this.nomeLiberadorClinicoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string Observacao1
        {
            get
            {
                return this.observacao1Field;
            }
            set
            {
                this.observacao1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string Observacao2
        {
            get
            {
                return this.observacao2Field;
            }
            set
            {
                this.observacao2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string Observacao3
        {
            get
            {
                return this.observacao3Field;
            }
            set
            {
                this.observacao3Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string Observacao4
        {
            get
            {
                return this.observacao4Field;
            }
            set
            {
                this.observacao4Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string Observacao5
        {
            get
            {
                return this.observacao5Field;
            }
            set
            {
                this.observacao5Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string Material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string IdentificacaoExameApoiado
        {
            get
            {
                return this.identificacaoExameApoiadoField;
            }
            set
            {
                this.identificacaoExameApoiadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public string MaterialApoiado
        {
            get
            {
                return this.materialApoiadoField;
            }
            set
            {
                this.materialApoiadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public string DescricaoMaterialApoiado
        {
            get
            {
                return this.descricaoMaterialApoiadoField;
            }
            set
            {
                this.descricaoMaterialApoiadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public string DescricaoExameApoiado
        {
            get
            {
                return this.descricaoExameApoiadoField;
            }
            set
            {
                this.descricaoExameApoiadoField = value;
            }
        }
    }

    public partial class ResultadoTexto
    {

        private string codigoParametroDBField;

        private string descricaoParametroDBField;

        private string valorResultadoField;

        private string unidadeMedidaField;

        private string valorReferenciaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string CodigoParametroDB
        {
            get
            {
                return this.codigoParametroDBField;
            }
            set
            {
                this.codigoParametroDBField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string DescricaoParametroDB
        {
            get
            {
                return this.descricaoParametroDBField;
            }
            set
            {
                this.descricaoParametroDBField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string ValorResultado
        {
            get
            {
                return this.valorResultadoField;
            }
            set
            {
                this.valorResultadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string UnidadeMedida
        {
            get
            {
                return this.unidadeMedidaField;
            }
            set
            {
                this.unidadeMedidaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string ValorReferencia
        {
            get
            {
                return this.valorReferenciaField;
            }
            set
            {
                this.valorReferenciaField = value;
            }
        }
    }

    public partial class ResultadoImagem
    {

        private string codigoParametroDBField;

        private byte[] valorResultadoImagemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string CodigoParametroDB
        {
            get
            {
                return this.codigoParametroDBField;
            }
            set
            {
                this.codigoParametroDBField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "base64Binary", Order = 1)]
        public byte[] ValorResultadoImagem
        {
            get
            {
                return this.valorResultadoImagemField;
            }
            set
            {
                this.valorResultadoImagemField = value;
            }
        }
    }
}

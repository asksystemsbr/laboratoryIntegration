using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntegracaoEntity.DiagnosticosBrasil
{
    public class DadosRequestRecebeAtendimentoDBViewModel
    {
        private Pedido pedidoField;
        
        public Pedido Pedido
        {
            get
            {
                return this.pedidoField;
            }
            set
            {
                this.pedidoField = value;
            }
        }
    }

    public partial class Pedido
    {

        private string numeroAtendimentoApoiadoField;

        private Paciente listaPacienteApoiadoField;

        private string numeroAtendimentoDBReservaField;

        private string codigoPrioridadeField;

        private string descricaoDadosClinicosField;

        private string descricaoMedicamentosField;

        private string dataHoraDUMField;

        private string alturaField;

        private string pesoField;

        private string usoApoiadoField;

        private string postoColetaField;

        private Questionario[] listaQuestionariosField;

        private Solicitante[] listaSolicitanteField;

        private Procedimento[] listaProcedimentoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public Paciente ListaPacienteApoiado
        {
            get
            {
                return this.listaPacienteApoiadoField;
            }
            set
            {
                this.listaPacienteApoiadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string NumeroAtendimentoDBReserva
        {
            get
            {
                return this.numeroAtendimentoDBReservaField;
            }
            set
            {
                this.numeroAtendimentoDBReservaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string CodigoPrioridade
        {
            get
            {
                return this.codigoPrioridadeField;
            }
            set
            {
                this.codigoPrioridadeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string DescricaoDadosClinicos
        {
            get
            {
                return this.descricaoDadosClinicosField;
            }
            set
            {
                this.descricaoDadosClinicosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string DescricaoMedicamentos
        {
            get
            {
                return this.descricaoMedicamentosField;
            }
            set
            {
                this.descricaoMedicamentosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string DataHoraDUM
        {
            get
            {
                return this.dataHoraDUMField;
            }
            set
            {
                this.dataHoraDUMField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string Altura
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string Peso
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string PostoColeta
        {
            get
            {
                return this.postoColetaField;
            }
            set
            {
                this.postoColetaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 11)]
        public Questionario[] ListaQuestionarios
        {
            get
            {
                return this.listaQuestionariosField;
            }
            set
            {
                this.listaQuestionariosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 12)]
        public Solicitante[] ListaSolicitante
        {
            get
            {
                return this.listaSolicitanteField;
            }
            set
            {
                this.listaSolicitanteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 13)]
        public Procedimento[] ListaProcedimento
        {
            get
            {
                return this.listaProcedimentoField;
            }
            set
            {
                this.listaProcedimentoField = value;
            }
        }
    }

    public partial class Paciente
    {

        private string rGPacienteApoiadoField;

        private string nomePacienteField;

        private string sexoPacienteField;

        private System.Nullable<System.DateTime> dataHoraPacienteField;

        private string numeroCPFField;

        private string numeroCartaoNacionalSaudeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string SexoPaciente
        {
            get
            {
                return this.sexoPacienteField;
            }
            set
            {
                this.sexoPacienteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 3)]
        public System.Nullable<System.DateTime> DataHoraPaciente
        {
            get
            {
                return this.dataHoraPacienteField;
            }
            set
            {
                this.dataHoraPacienteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string NumeroCartaoNacionalSaude
        {
            get
            {
                return this.numeroCartaoNacionalSaudeField;
            }
            set
            {
                this.numeroCartaoNacionalSaudeField = value;
            }
        }
    }

    public partial class Questionario
    {

        private string codigoPerguntaQuestionarioField;

        private string respostaQuestionarioField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string CodigoPerguntaQuestionario
        {
            get
            {
                return this.codigoPerguntaQuestionarioField;
            }
            set
            {
                this.codigoPerguntaQuestionarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string RespostaQuestionario
        {
            get
            {
                return this.respostaQuestionarioField;
            }
            set
            {
                this.respostaQuestionarioField = value;
            }
        }
    }

    public partial class Solicitante
    {

        private string nomeSolicitanteField;

        private string codigoConselhoField;

        private string codigoUFConselhoSolicitanteField;

        private string codigoConselhoSolicitanteField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string NomeSolicitante
        {
            get
            {
                return this.nomeSolicitanteField;
            }
            set
            {
                this.nomeSolicitanteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string CodigoConselho
        {
            get
            {
                return this.codigoConselhoField;
            }
            set
            {
                this.codigoConselhoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string CodigoUFConselhoSolicitante
        {
            get
            {
                return this.codigoUFConselhoSolicitanteField;
            }
            set
            {
                this.codigoUFConselhoSolicitanteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string CodigoConselhoSolicitante
        {
            get
            {
                return this.codigoConselhoSolicitanteField;
            }
            set
            {
                this.codigoConselhoSolicitanteField = value;
            }
        }
    }

    public partial class Procedimento
    {

        private string codigoExameDBField;

        private string descricaoRegiaoColetaField;

        private string volumeUrinarioField;

        private string identificacaoExameApoiadoField;

        private string materialApoiadoField;

        private string descricaoMaterialApoiadoField;

        private string descricaoExameApoiadoField;

        private string codigoMPPField;

        private AmostraColeta[] amostrasField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string CodigoExameDB
        {
            get
            {
                return this.codigoExameDBField;
            }
            set
            {
                this.codigoExameDBField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string VolumeUrinario
        {
            get
            {
                return this.volumeUrinarioField;
            }
            set
            {
                this.volumeUrinarioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string CodigoMPP
        {
            get
            {
                return this.codigoMPPField;
            }
            set
            {
                this.codigoMPPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 8)]
        public AmostraColeta[] Amostras
        {
            get
            {
                return this.amostrasField;
            }
            set
            {
                this.amostrasField = value;
            }
        }
    }

    public partial class AmostraColeta
    {

        private string numeroAmostraField;

        private string meioColetaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string NumeroAmostra
        {
            get
            {
                return this.numeroAmostraField;
            }
            set
            {
                this.numeroAmostraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string MeioColeta
        {
            get
            {
                return this.meioColetaField;
            }
            set
            {
                this.meioColetaField = value;
            }
        }
    }


}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppAgenciaViajes.TipoDocumentoServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TipoDocumento", Namespace="http://schemas.datacontract.org/2004/07/AgenciaVObjetos")]
    [System.SerializableAttribute()]
    public partial class TipoDocumento : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TipoDocumentoFechaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TipoDocumentoIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoDocumentoNombreField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TipoDocumentoFecha {
            get {
                return this.TipoDocumentoFechaField;
            }
            set {
                if ((this.TipoDocumentoFechaField.Equals(value) != true)) {
                    this.TipoDocumentoFechaField = value;
                    this.RaisePropertyChanged("TipoDocumentoFecha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TipoDocumentoID {
            get {
                return this.TipoDocumentoIDField;
            }
            set {
                if ((this.TipoDocumentoIDField.Equals(value) != true)) {
                    this.TipoDocumentoIDField = value;
                    this.RaisePropertyChanged("TipoDocumentoID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoDocumentoNombre {
            get {
                return this.TipoDocumentoNombreField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoDocumentoNombreField, value) != true)) {
                    this.TipoDocumentoNombreField = value;
                    this.RaisePropertyChanged("TipoDocumentoNombre");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TipoDocumentoServiceReference.ISvcTipoDocumento")]
    public interface ISvcTipoDocumento {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISvcTipoDocumento/Consultar", ReplyAction="http://tempuri.org/ISvcTipoDocumento/ConsultarResponse")]
        System.Collections.Generic.List<AppAgenciaViajes.TipoDocumentoServiceReference.TipoDocumento> Consultar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISvcTipoDocumento/Consultar", ReplyAction="http://tempuri.org/ISvcTipoDocumento/ConsultarResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<AppAgenciaViajes.TipoDocumentoServiceReference.TipoDocumento>> ConsultarAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISvcTipoDocumentoChannel : AppAgenciaViajes.TipoDocumentoServiceReference.ISvcTipoDocumento, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SvcTipoDocumentoClient : System.ServiceModel.ClientBase<AppAgenciaViajes.TipoDocumentoServiceReference.ISvcTipoDocumento>, AppAgenciaViajes.TipoDocumentoServiceReference.ISvcTipoDocumento {
        
        public SvcTipoDocumentoClient() {
        }
        
        public SvcTipoDocumentoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SvcTipoDocumentoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SvcTipoDocumentoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SvcTipoDocumentoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<AppAgenciaViajes.TipoDocumentoServiceReference.TipoDocumento> Consultar() {
            return base.Channel.Consultar();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<AppAgenciaViajes.TipoDocumentoServiceReference.TipoDocumento>> ConsultarAsync() {
            return base.Channel.ConsultarAsync();
        }
    }
}
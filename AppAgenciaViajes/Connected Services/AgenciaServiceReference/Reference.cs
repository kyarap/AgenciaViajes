﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppAgenciaViajes.AgenciaServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Pais", Namespace="http://schemas.datacontract.org/2004/07/AgenciaVObjetos")]
    [System.SerializableAttribute()]
    public partial class Pais : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime PaisFechaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PaisIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PaisNombreField;
        
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
        public System.DateTime PaisFecha {
            get {
                return this.PaisFechaField;
            }
            set {
                if ((this.PaisFechaField.Equals(value) != true)) {
                    this.PaisFechaField = value;
                    this.RaisePropertyChanged("PaisFecha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PaisID {
            get {
                return this.PaisIDField;
            }
            set {
                if ((this.PaisIDField.Equals(value) != true)) {
                    this.PaisIDField = value;
                    this.RaisePropertyChanged("PaisID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PaisNombre {
            get {
                return this.PaisNombreField;
            }
            set {
                if ((object.ReferenceEquals(this.PaisNombreField, value) != true)) {
                    this.PaisNombreField = value;
                    this.RaisePropertyChanged("PaisNombre");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AgenciaServiceReference.ISvcPais")]
    public interface ISvcPais {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISvcPais/Consultar", ReplyAction="http://tempuri.org/ISvcPais/ConsultarResponse")]
        System.Collections.Generic.List<AppAgenciaViajes.AgenciaServiceReference.Pais> Consultar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISvcPais/Consultar", ReplyAction="http://tempuri.org/ISvcPais/ConsultarResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<AppAgenciaViajes.AgenciaServiceReference.Pais>> ConsultarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISvcPais/Insertar", ReplyAction="http://tempuri.org/ISvcPais/InsertarResponse")]
        bool Insertar(AppAgenciaViajes.AgenciaServiceReference.Pais pais);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISvcPais/Insertar", ReplyAction="http://tempuri.org/ISvcPais/InsertarResponse")]
        System.Threading.Tasks.Task<bool> InsertarAsync(AppAgenciaViajes.AgenciaServiceReference.Pais pais);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISvcPaisChannel : AppAgenciaViajes.AgenciaServiceReference.ISvcPais, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SvcPaisClient : System.ServiceModel.ClientBase<AppAgenciaViajes.AgenciaServiceReference.ISvcPais>, AppAgenciaViajes.AgenciaServiceReference.ISvcPais {
        
        public SvcPaisClient() {
        }
        
        public SvcPaisClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SvcPaisClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SvcPaisClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SvcPaisClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<AppAgenciaViajes.AgenciaServiceReference.Pais> Consultar() {
            return base.Channel.Consultar();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<AppAgenciaViajes.AgenciaServiceReference.Pais>> ConsultarAsync() {
            return base.Channel.ConsultarAsync();
        }
        
        public bool Insertar(AppAgenciaViajes.AgenciaServiceReference.Pais pais) {
            return base.Channel.Insertar(pais);
        }
        
        public System.Threading.Tasks.Task<bool> InsertarAsync(AppAgenciaViajes.AgenciaServiceReference.Pais pais) {
            return base.Channel.InsertarAsync(pais);
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppAgenciaViajes.ServicioAdicionalServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ServicioAdicional", Namespace="http://schemas.datacontract.org/2004/07/AgenciaVObjetos")]
    [System.SerializableAttribute()]
    public partial class ServicioAdicional : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServicioAdicionalDescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ServicioAdicionalFechaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ServicioAdicionalIDField;
        
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
        public string ServicioAdicionalDescripcion {
            get {
                return this.ServicioAdicionalDescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.ServicioAdicionalDescripcionField, value) != true)) {
                    this.ServicioAdicionalDescripcionField = value;
                    this.RaisePropertyChanged("ServicioAdicionalDescripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ServicioAdicionalFecha {
            get {
                return this.ServicioAdicionalFechaField;
            }
            set {
                if ((this.ServicioAdicionalFechaField.Equals(value) != true)) {
                    this.ServicioAdicionalFechaField = value;
                    this.RaisePropertyChanged("ServicioAdicionalFecha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ServicioAdicionalID {
            get {
                return this.ServicioAdicionalIDField;
            }
            set {
                if ((this.ServicioAdicionalIDField.Equals(value) != true)) {
                    this.ServicioAdicionalIDField = value;
                    this.RaisePropertyChanged("ServicioAdicionalID");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioAdicionalServiceReference.ISvcServicioAdicional")]
    public interface ISvcServicioAdicional {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISvcServicioAdicional/Consultar", ReplyAction="http://tempuri.org/ISvcServicioAdicional/ConsultarResponse")]
        System.Collections.Generic.List<AppAgenciaViajes.ServicioAdicionalServiceReference.ServicioAdicional> Consultar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISvcServicioAdicional/Consultar", ReplyAction="http://tempuri.org/ISvcServicioAdicional/ConsultarResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<AppAgenciaViajes.ServicioAdicionalServiceReference.ServicioAdicional>> ConsultarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISvcServicioAdicional/Insertar", ReplyAction="http://tempuri.org/ISvcServicioAdicional/InsertarResponse")]
        bool Insertar(AppAgenciaViajes.ServicioAdicionalServiceReference.ServicioAdicional ServicioAdicional);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISvcServicioAdicional/Insertar", ReplyAction="http://tempuri.org/ISvcServicioAdicional/InsertarResponse")]
        System.Threading.Tasks.Task<bool> InsertarAsync(AppAgenciaViajes.ServicioAdicionalServiceReference.ServicioAdicional ServicioAdicional);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISvcServicioAdicionalChannel : AppAgenciaViajes.ServicioAdicionalServiceReference.ISvcServicioAdicional, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SvcServicioAdicionalClient : System.ServiceModel.ClientBase<AppAgenciaViajes.ServicioAdicionalServiceReference.ISvcServicioAdicional>, AppAgenciaViajes.ServicioAdicionalServiceReference.ISvcServicioAdicional {
        
        public SvcServicioAdicionalClient() {
        }
        
        public SvcServicioAdicionalClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SvcServicioAdicionalClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SvcServicioAdicionalClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SvcServicioAdicionalClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<AppAgenciaViajes.ServicioAdicionalServiceReference.ServicioAdicional> Consultar() {
            return base.Channel.Consultar();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<AppAgenciaViajes.ServicioAdicionalServiceReference.ServicioAdicional>> ConsultarAsync() {
            return base.Channel.ConsultarAsync();
        }
        
        public bool Insertar(AppAgenciaViajes.ServicioAdicionalServiceReference.ServicioAdicional ServicioAdicional) {
            return base.Channel.Insertar(ServicioAdicional);
        }
        
        public System.Threading.Tasks.Task<bool> InsertarAsync(AppAgenciaViajes.ServicioAdicionalServiceReference.ServicioAdicional ServicioAdicional) {
            return base.Channel.InsertarAsync(ServicioAdicional);
        }
    }
}

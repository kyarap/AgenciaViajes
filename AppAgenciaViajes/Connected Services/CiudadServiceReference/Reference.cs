﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppAgenciaViajes.CiudadServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Ciudad", Namespace="http://schemas.datacontract.org/2004/07/AgenciaVObjetos")]
    [System.SerializableAttribute()]
    public partial class Ciudad : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CiudadFechaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CiudadIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CiudadNombreField;
        
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
        public System.DateTime CiudadFecha {
            get {
                return this.CiudadFechaField;
            }
            set {
                if ((this.CiudadFechaField.Equals(value) != true)) {
                    this.CiudadFechaField = value;
                    this.RaisePropertyChanged("CiudadFecha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CiudadID {
            get {
                return this.CiudadIDField;
            }
            set {
                if ((this.CiudadIDField.Equals(value) != true)) {
                    this.CiudadIDField = value;
                    this.RaisePropertyChanged("CiudadID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CiudadNombre {
            get {
                return this.CiudadNombreField;
            }
            set {
                if ((object.ReferenceEquals(this.CiudadNombreField, value) != true)) {
                    this.CiudadNombreField = value;
                    this.RaisePropertyChanged("CiudadNombre");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CiudadServiceReference.ISvcCiudad")]
    public interface ISvcCiudad {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISvcCiudad/Consultar", ReplyAction="http://tempuri.org/ISvcCiudad/ConsultarResponse")]
        AppAgenciaViajes.CiudadServiceReference.Ciudad[] Consultar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISvcCiudad/Consultar", ReplyAction="http://tempuri.org/ISvcCiudad/ConsultarResponse")]
        System.Threading.Tasks.Task<AppAgenciaViajes.CiudadServiceReference.Ciudad[]> ConsultarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISvcCiudad/ConsultarCiudadXPais", ReplyAction="http://tempuri.org/ISvcCiudad/ConsultarCiudadXPaisResponse")]
        AppAgenciaViajes.CiudadServiceReference.Ciudad[] ConsultarCiudadXPais(int idPais);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISvcCiudad/ConsultarCiudadXPais", ReplyAction="http://tempuri.org/ISvcCiudad/ConsultarCiudadXPaisResponse")]
        System.Threading.Tasks.Task<AppAgenciaViajes.CiudadServiceReference.Ciudad[]> ConsultarCiudadXPaisAsync(int idPais);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISvcCiudadChannel : AppAgenciaViajes.CiudadServiceReference.ISvcCiudad, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SvcCiudadClient : System.ServiceModel.ClientBase<AppAgenciaViajes.CiudadServiceReference.ISvcCiudad>, AppAgenciaViajes.CiudadServiceReference.ISvcCiudad {
        
        public SvcCiudadClient() {
        }
        
        public SvcCiudadClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SvcCiudadClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SvcCiudadClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SvcCiudadClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AppAgenciaViajes.CiudadServiceReference.Ciudad[] Consultar() {
            return base.Channel.Consultar();
        }
        
        public System.Threading.Tasks.Task<AppAgenciaViajes.CiudadServiceReference.Ciudad[]> ConsultarAsync() {
            return base.Channel.ConsultarAsync();
        }
        
        public AppAgenciaViajes.CiudadServiceReference.Ciudad[] ConsultarCiudadXPais(int idPais) {
            return base.Channel.ConsultarCiudadXPais(idPais);
        }
        
        public System.Threading.Tasks.Task<AppAgenciaViajes.CiudadServiceReference.Ciudad[]> ConsultarCiudadXPaisAsync(int idPais) {
            return base.Channel.ConsultarCiudadXPaisAsync(idPais);
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfClient.GisServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="City", Namespace="http://schemas.datacontract.org/2004/07/GisData.db")]
    [System.SerializableAttribute()]
    public partial class City : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long Gis_IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public long Gis_Id {
            get {
                return this.Gis_IdField;
            }
            set {
                if ((this.Gis_IdField.Equals(value) != true)) {
                    this.Gis_IdField = value;
                    this.RaisePropertyChanged("Gis_Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Prognosis", Namespace="http://schemas.datacontract.org/2004/07/GisData.db")]
    [System.SerializableAttribute()]
    public partial class Prognosis : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float Air_tempField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long City_IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float Comfort_tempField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float HumidityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float PressureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float Water_tempField;
        
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
        public float Air_temp {
            get {
                return this.Air_tempField;
            }
            set {
                if ((this.Air_tempField.Equals(value) != true)) {
                    this.Air_tempField = value;
                    this.RaisePropertyChanged("Air_temp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long City_Id {
            get {
                return this.City_IdField;
            }
            set {
                if ((this.City_IdField.Equals(value) != true)) {
                    this.City_IdField = value;
                    this.RaisePropertyChanged("City_Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Comfort_temp {
            get {
                return this.Comfort_tempField;
            }
            set {
                if ((this.Comfort_tempField.Equals(value) != true)) {
                    this.Comfort_tempField = value;
                    this.RaisePropertyChanged("Comfort_temp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Humidity {
            get {
                return this.HumidityField;
            }
            set {
                if ((this.HumidityField.Equals(value) != true)) {
                    this.HumidityField = value;
                    this.RaisePropertyChanged("Humidity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Pressure {
            get {
                return this.PressureField;
            }
            set {
                if ((this.PressureField.Equals(value) != true)) {
                    this.PressureField = value;
                    this.RaisePropertyChanged("Pressure");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Water_temp {
            get {
                return this.Water_tempField;
            }
            set {
                if ((this.Water_tempField.Equals(value) != true)) {
                    this.Water_tempField = value;
                    this.RaisePropertyChanged("Water_temp");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GisServiceReference.IGisService")]
    public interface IGisService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGisService/GetAllCities", ReplyAction="http://tempuri.org/IGisService/GetAllCitiesResponse")]
        WpfClient.GisServiceReference.City[] GetAllCities();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGisService/GetAllCities", ReplyAction="http://tempuri.org/IGisService/GetAllCitiesResponse")]
        System.Threading.Tasks.Task<WpfClient.GisServiceReference.City[]> GetAllCitiesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGisService/GetAllPrognoses", ReplyAction="http://tempuri.org/IGisService/GetAllPrognosesResponse")]
        WpfClient.GisServiceReference.Prognosis[] GetAllPrognoses();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGisService/GetAllPrognoses", ReplyAction="http://tempuri.org/IGisService/GetAllPrognosesResponse")]
        System.Threading.Tasks.Task<WpfClient.GisServiceReference.Prognosis[]> GetAllPrognosesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGisService/GetPrognosesByCity", ReplyAction="http://tempuri.org/IGisService/GetPrognosesByCityResponse")]
        WpfClient.GisServiceReference.Prognosis[] GetPrognosesByCity(long cityId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGisService/GetPrognosesByCity", ReplyAction="http://tempuri.org/IGisService/GetPrognosesByCityResponse")]
        System.Threading.Tasks.Task<WpfClient.GisServiceReference.Prognosis[]> GetPrognosesByCityAsync(long cityId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGisService/GetLatestPrognosisByCity", ReplyAction="http://tempuri.org/IGisService/GetLatestPrognosisByCityResponse")]
        WpfClient.GisServiceReference.Prognosis GetLatestPrognosisByCity(long cityId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGisService/GetLatestPrognosisByCity", ReplyAction="http://tempuri.org/IGisService/GetLatestPrognosisByCityResponse")]
        System.Threading.Tasks.Task<WpfClient.GisServiceReference.Prognosis> GetLatestPrognosisByCityAsync(long cityId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGisServiceChannel : WpfClient.GisServiceReference.IGisService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GisServiceClient : System.ServiceModel.ClientBase<WpfClient.GisServiceReference.IGisService>, WpfClient.GisServiceReference.IGisService {
        
        public GisServiceClient() {
        }
        
        public GisServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GisServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GisServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GisServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WpfClient.GisServiceReference.City[] GetAllCities() {
            return base.Channel.GetAllCities();
        }
        
        public System.Threading.Tasks.Task<WpfClient.GisServiceReference.City[]> GetAllCitiesAsync() {
            return base.Channel.GetAllCitiesAsync();
        }
        
        public WpfClient.GisServiceReference.Prognosis[] GetAllPrognoses() {
            return base.Channel.GetAllPrognoses();
        }
        
        public System.Threading.Tasks.Task<WpfClient.GisServiceReference.Prognosis[]> GetAllPrognosesAsync() {
            return base.Channel.GetAllPrognosesAsync();
        }
        
        public WpfClient.GisServiceReference.Prognosis[] GetPrognosesByCity(long cityId) {
            return base.Channel.GetPrognosesByCity(cityId);
        }
        
        public System.Threading.Tasks.Task<WpfClient.GisServiceReference.Prognosis[]> GetPrognosesByCityAsync(long cityId) {
            return base.Channel.GetPrognosesByCityAsync(cityId);
        }
        
        public WpfClient.GisServiceReference.Prognosis GetLatestPrognosisByCity(long cityId) {
            return base.Channel.GetLatestPrognosisByCity(cityId);
        }
        
        public System.Threading.Tasks.Task<WpfClient.GisServiceReference.Prognosis> GetLatestPrognosisByCityAsync(long cityId) {
            return base.Channel.GetLatestPrognosisByCityAsync(cityId);
        }
    }
}

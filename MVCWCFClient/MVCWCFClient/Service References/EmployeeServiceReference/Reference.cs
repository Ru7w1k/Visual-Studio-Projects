﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCWCFClient.EmployeeServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Department", Namespace="http://schemas.datacontract.org/2004/07/WCFDemo")]
    [System.SerializableAttribute()]
    public partial class Department : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
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
        public int Id {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/WCFDemo")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MVCWCFClient.EmployeeServiceReference.Admin))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MVCWCFClient.EmployeeServiceReference.Manager))]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double SalaryField;
        
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
        public int Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Salary {
            get {
                return this.SalaryField;
            }
            set {
                if ((this.SalaryField.Equals(value) != true)) {
                    this.SalaryField = value;
                    this.RaisePropertyChanged("Salary");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Admin", Namespace="http://schemas.datacontract.org/2004/07/WCFDemo")]
    [System.SerializableAttribute()]
    public partial class Admin : MVCWCFClient.EmployeeServiceReference.Employee {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Manager", Namespace="http://schemas.datacontract.org/2004/07/WCFDemo")]
    [System.SerializableAttribute()]
    public partial class Manager : MVCWCFClient.EmployeeServiceReference.Employee {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeServiceReference.IEmployeeService")]
    public interface IEmployeeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployeeDetails", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeeDetailsResponse")]
        MVCWCFClient.EmployeeServiceReference.EmployeeResponse GetEmployeeDetails(MVCWCFClient.EmployeeServiceReference.EmployeeRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployeeDetails", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeeDetailsResponse")]
        System.Threading.Tasks.Task<MVCWCFClient.EmployeeServiceReference.EmployeeResponse> GetEmployeeDetailsAsync(MVCWCFClient.EmployeeServiceReference.EmployeeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployeeDetailsById", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeeDetailsByIdResponse")]
        MVCWCFClient.EmployeeServiceReference.EmployeeResponse GetEmployeeDetailsById(MVCWCFClient.EmployeeServiceReference.EmployeeRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/GetEmployeeDetailsById", ReplyAction="http://tempuri.org/IEmployeeService/GetEmployeeDetailsByIdResponse")]
        System.Threading.Tasks.Task<MVCWCFClient.EmployeeServiceReference.EmployeeResponse> GetEmployeeDetailsByIdAsync(MVCWCFClient.EmployeeServiceReference.EmployeeRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EmployeeRequest", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class EmployeeRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string Key;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int DeptId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int Id;
        
        public EmployeeRequest() {
        }
        
        public EmployeeRequest(string Key, int DeptId, int Id) {
            this.Key = Key;
            this.DeptId = DeptId;
            this.Id = Id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EmployeeResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class EmployeeResponse {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string CompanyName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public MVCWCFClient.EmployeeServiceReference.Department Dept;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public MVCWCFClient.EmployeeServiceReference.Employee[] Emp;
        
        public EmployeeResponse() {
        }
        
        public EmployeeResponse(string CompanyName, MVCWCFClient.EmployeeServiceReference.Department Dept, MVCWCFClient.EmployeeServiceReference.Employee[] Emp) {
            this.CompanyName = CompanyName;
            this.Dept = Dept;
            this.Emp = Emp;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeServiceChannel : MVCWCFClient.EmployeeServiceReference.IEmployeeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeServiceClient : System.ServiceModel.ClientBase<MVCWCFClient.EmployeeServiceReference.IEmployeeService>, MVCWCFClient.EmployeeServiceReference.IEmployeeService {
        
        public EmployeeServiceClient() {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MVCWCFClient.EmployeeServiceReference.EmployeeResponse MVCWCFClient.EmployeeServiceReference.IEmployeeService.GetEmployeeDetails(MVCWCFClient.EmployeeServiceReference.EmployeeRequest request) {
            return base.Channel.GetEmployeeDetails(request);
        }
        
        public string GetEmployeeDetails(string Key, int DeptId, int Id, out MVCWCFClient.EmployeeServiceReference.Department Dept, out MVCWCFClient.EmployeeServiceReference.Employee[] Emp) {
            MVCWCFClient.EmployeeServiceReference.EmployeeRequest inValue = new MVCWCFClient.EmployeeServiceReference.EmployeeRequest();
            inValue.Key = Key;
            inValue.DeptId = DeptId;
            inValue.Id = Id;
            MVCWCFClient.EmployeeServiceReference.EmployeeResponse retVal = ((MVCWCFClient.EmployeeServiceReference.IEmployeeService)(this)).GetEmployeeDetails(inValue);
            Dept = retVal.Dept;
            Emp = retVal.Emp;
            return retVal.CompanyName;
        }
        
        public System.Threading.Tasks.Task<MVCWCFClient.EmployeeServiceReference.EmployeeResponse> GetEmployeeDetailsAsync(MVCWCFClient.EmployeeServiceReference.EmployeeRequest request) {
            return base.Channel.GetEmployeeDetailsAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MVCWCFClient.EmployeeServiceReference.EmployeeResponse MVCWCFClient.EmployeeServiceReference.IEmployeeService.GetEmployeeDetailsById(MVCWCFClient.EmployeeServiceReference.EmployeeRequest request) {
            return base.Channel.GetEmployeeDetailsById(request);
        }
        
        public string GetEmployeeDetailsById(string Key, int DeptId, int Id, out MVCWCFClient.EmployeeServiceReference.Department Dept, out MVCWCFClient.EmployeeServiceReference.Employee[] Emp) {
            MVCWCFClient.EmployeeServiceReference.EmployeeRequest inValue = new MVCWCFClient.EmployeeServiceReference.EmployeeRequest();
            inValue.Key = Key;
            inValue.DeptId = DeptId;
            inValue.Id = Id;
            MVCWCFClient.EmployeeServiceReference.EmployeeResponse retVal = ((MVCWCFClient.EmployeeServiceReference.IEmployeeService)(this)).GetEmployeeDetailsById(inValue);
            Dept = retVal.Dept;
            Emp = retVal.Emp;
            return retVal.CompanyName;
        }
        
        public System.Threading.Tasks.Task<MVCWCFClient.EmployeeServiceReference.EmployeeResponse> GetEmployeeDetailsByIdAsync(MVCWCFClient.EmployeeServiceReference.EmployeeRequest request) {
            return base.Channel.GetEmployeeDetailsByIdAsync(request);
        }
    }
}

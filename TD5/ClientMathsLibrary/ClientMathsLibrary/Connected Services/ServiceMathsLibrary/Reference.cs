﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientMathsLibrary.ServiceMathsLibrary {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceMathsLibrary.IMathsOperations")]
    public interface IMathsOperations {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathsOperations/Add", ReplyAction="http://tempuri.org/IMathsOperations/AddResponse")]
        int Add(int valueA, int valueB);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathsOperations/Add", ReplyAction="http://tempuri.org/IMathsOperations/AddResponse")]
        System.Threading.Tasks.Task<int> AddAsync(int valueA, int valueB);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathsOperations/Multiply", ReplyAction="http://tempuri.org/IMathsOperations/MultiplyResponse")]
        int Multiply(int valueA, int valueB);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathsOperations/Multiply", ReplyAction="http://tempuri.org/IMathsOperations/MultiplyResponse")]
        System.Threading.Tasks.Task<int> MultiplyAsync(int valueA, int valueB);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathsOperations/Substract", ReplyAction="http://tempuri.org/IMathsOperations/SubstractResponse")]
        int Substract(int valueA, int valueB);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathsOperations/Substract", ReplyAction="http://tempuri.org/IMathsOperations/SubstractResponse")]
        System.Threading.Tasks.Task<int> SubstractAsync(int valueA, int valueB);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathsOperations/Divide", ReplyAction="http://tempuri.org/IMathsOperations/DivideResponse")]
        double Divide(int valueA, int valueB);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMathsOperations/Divide", ReplyAction="http://tempuri.org/IMathsOperations/DivideResponse")]
        System.Threading.Tasks.Task<double> DivideAsync(int valueA, int valueB);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMathsOperationsChannel : ClientMathsLibrary.ServiceMathsLibrary.IMathsOperations, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MathsOperationsClient : System.ServiceModel.ClientBase<ClientMathsLibrary.ServiceMathsLibrary.IMathsOperations>, ClientMathsLibrary.ServiceMathsLibrary.IMathsOperations {
        
        public MathsOperationsClient() {
        }
        
        public MathsOperationsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MathsOperationsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MathsOperationsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MathsOperationsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(int valueA, int valueB) {
            return base.Channel.Add(valueA, valueB);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int valueA, int valueB) {
            return base.Channel.AddAsync(valueA, valueB);
        }
        
        public int Multiply(int valueA, int valueB) {
            return base.Channel.Multiply(valueA, valueB);
        }
        
        public System.Threading.Tasks.Task<int> MultiplyAsync(int valueA, int valueB) {
            return base.Channel.MultiplyAsync(valueA, valueB);
        }
        
        public int Substract(int valueA, int valueB) {
            return base.Channel.Substract(valueA, valueB);
        }
        
        public System.Threading.Tasks.Task<int> SubstractAsync(int valueA, int valueB) {
            return base.Channel.SubstractAsync(valueA, valueB);
        }
        
        public double Divide(int valueA, int valueB) {
            return base.Channel.Divide(valueA, valueB);
        }
        
        public System.Threading.Tasks.Task<double> DivideAsync(int valueA, int valueB) {
            return base.Channel.DivideAsync(valueA, valueB);
        }
    }
}

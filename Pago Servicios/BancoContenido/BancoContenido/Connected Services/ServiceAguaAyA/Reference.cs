﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BancoContenido.ServiceAguaAyA {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceAguaAyA.IPagoAguaAyA")]
    public interface IPagoAguaAyA {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPagoAguaAyA/montopago", ReplyAction="http://tempuri.org/IPagoAguaAyA/montopagoResponse")]
        string montopago(string medidor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPagoAguaAyA/montopago", ReplyAction="http://tempuri.org/IPagoAguaAyA/montopagoResponse")]
        System.Threading.Tasks.Task<string> montopagoAsync(string medidor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPagoAguaAyA/pago", ReplyAction="http://tempuri.org/IPagoAguaAyA/pagoResponse")]
        string pago(string medidor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPagoAguaAyA/pago", ReplyAction="http://tempuri.org/IPagoAguaAyA/pagoResponse")]
        System.Threading.Tasks.Task<string> pagoAsync(string medidor);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPagoAguaAyAChannel : BancoContenido.ServiceAguaAyA.IPagoAguaAyA, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PagoAguaAyAClient : System.ServiceModel.ClientBase<BancoContenido.ServiceAguaAyA.IPagoAguaAyA>, BancoContenido.ServiceAguaAyA.IPagoAguaAyA {
        
        public PagoAguaAyAClient() {
        }
        
        public PagoAguaAyAClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PagoAguaAyAClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PagoAguaAyAClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PagoAguaAyAClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string montopago(string medidor) {
            return base.Channel.montopago(medidor);
        }
        
        public System.Threading.Tasks.Task<string> montopagoAsync(string medidor) {
            return base.Channel.montopagoAsync(medidor);
        }
        
        public string pago(string medidor) {
            return base.Channel.pago(medidor);
        }
        
        public System.Threading.Tasks.Task<string> pagoAsync(string medidor) {
            return base.Channel.pagoAsync(medidor);
        }
    }
}

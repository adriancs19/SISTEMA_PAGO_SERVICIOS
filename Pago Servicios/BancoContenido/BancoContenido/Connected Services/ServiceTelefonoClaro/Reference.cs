﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BancoContenido.ServiceTelefonoClaro {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceTelefonoClaro.IPagoTelefonoClaro")]
    public interface IPagoTelefonoClaro {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPagoTelefonoClaro/montopago", ReplyAction="http://tempuri.org/IPagoTelefonoClaro/montopagoResponse")]
        string montopago(string medidor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPagoTelefonoClaro/montopago", ReplyAction="http://tempuri.org/IPagoTelefonoClaro/montopagoResponse")]
        System.Threading.Tasks.Task<string> montopagoAsync(string medidor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPagoTelefonoClaro/pago", ReplyAction="http://tempuri.org/IPagoTelefonoClaro/pagoResponse")]
        string pago(string medidor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPagoTelefonoClaro/pago", ReplyAction="http://tempuri.org/IPagoTelefonoClaro/pagoResponse")]
        System.Threading.Tasks.Task<string> pagoAsync(string medidor);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPagoTelefonoClaroChannel : BancoContenido.ServiceTelefonoClaro.IPagoTelefonoClaro, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PagoTelefonoClaroClient : System.ServiceModel.ClientBase<BancoContenido.ServiceTelefonoClaro.IPagoTelefonoClaro>, BancoContenido.ServiceTelefonoClaro.IPagoTelefonoClaro {
        
        public PagoTelefonoClaroClient() {
        }
        
        public PagoTelefonoClaroClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PagoTelefonoClaroClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PagoTelefonoClaroClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PagoTelefonoClaroClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
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

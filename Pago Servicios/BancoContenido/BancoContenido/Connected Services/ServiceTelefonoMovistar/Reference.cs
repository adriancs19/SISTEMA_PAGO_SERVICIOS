﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BancoContenido.ServiceTelefonoMovistar {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceTelefonoMovistar.IPagoTelefonoMovistar")]
    public interface IPagoTelefonoMovistar {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPagoTelefonoMovistar/montopago", ReplyAction="http://tempuri.org/IPagoTelefonoMovistar/montopagoResponse")]
        string montopago(string medidor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPagoTelefonoMovistar/montopago", ReplyAction="http://tempuri.org/IPagoTelefonoMovistar/montopagoResponse")]
        System.Threading.Tasks.Task<string> montopagoAsync(string medidor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPagoTelefonoMovistar/pago", ReplyAction="http://tempuri.org/IPagoTelefonoMovistar/pagoResponse")]
        string pago(string medidor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPagoTelefonoMovistar/pago", ReplyAction="http://tempuri.org/IPagoTelefonoMovistar/pagoResponse")]
        System.Threading.Tasks.Task<string> pagoAsync(string medidor);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPagoTelefonoMovistarChannel : BancoContenido.ServiceTelefonoMovistar.IPagoTelefonoMovistar, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PagoTelefonoMovistarClient : System.ServiceModel.ClientBase<BancoContenido.ServiceTelefonoMovistar.IPagoTelefonoMovistar>, BancoContenido.ServiceTelefonoMovistar.IPagoTelefonoMovistar {
        
        public PagoTelefonoMovistarClient() {
        }
        
        public PagoTelefonoMovistarClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PagoTelefonoMovistarClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PagoTelefonoMovistarClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PagoTelefonoMovistarClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
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
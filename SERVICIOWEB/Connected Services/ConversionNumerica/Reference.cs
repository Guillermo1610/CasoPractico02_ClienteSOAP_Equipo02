﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SERVICIOWEB.ConversionNumerica {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.dataaccess.com/webservicesserver/", ConfigurationName="ConversionNumerica.NumberConversionSoapType")]
    public interface NumberConversionSoapType {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento NumberToWordsResult del espacio de nombres http://www.dataaccess.com/webservicesserver/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        SERVICIOWEB.ConversionNumerica.NumberToWordsResponse NumberToWords(SERVICIOWEB.ConversionNumerica.NumberToWordsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<SERVICIOWEB.ConversionNumerica.NumberToWordsResponse> NumberToWordsAsync(SERVICIOWEB.ConversionNumerica.NumberToWordsRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento NumberToDollarsResult del espacio de nombres http://www.dataaccess.com/webservicesserver/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        SERVICIOWEB.ConversionNumerica.NumberToDollarsResponse NumberToDollars(SERVICIOWEB.ConversionNumerica.NumberToDollarsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<SERVICIOWEB.ConversionNumerica.NumberToDollarsResponse> NumberToDollarsAsync(SERVICIOWEB.ConversionNumerica.NumberToDollarsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class NumberToWordsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="NumberToWords", Namespace="http://www.dataaccess.com/webservicesserver/", Order=0)]
        public SERVICIOWEB.ConversionNumerica.NumberToWordsRequestBody Body;
        
        public NumberToWordsRequest() {
        }
        
        public NumberToWordsRequest(SERVICIOWEB.ConversionNumerica.NumberToWordsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.dataaccess.com/webservicesserver/")]
    public partial class NumberToWordsRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public ulong ubiNum;
        
        public NumberToWordsRequestBody() {
        }
        
        public NumberToWordsRequestBody(ulong ubiNum) {
            this.ubiNum = ubiNum;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class NumberToWordsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="NumberToWordsResponse", Namespace="http://www.dataaccess.com/webservicesserver/", Order=0)]
        public SERVICIOWEB.ConversionNumerica.NumberToWordsResponseBody Body;
        
        public NumberToWordsResponse() {
        }
        
        public NumberToWordsResponse(SERVICIOWEB.ConversionNumerica.NumberToWordsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.dataaccess.com/webservicesserver/")]
    public partial class NumberToWordsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string NumberToWordsResult;
        
        public NumberToWordsResponseBody() {
        }
        
        public NumberToWordsResponseBody(string NumberToWordsResult) {
            this.NumberToWordsResult = NumberToWordsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class NumberToDollarsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="NumberToDollars", Namespace="http://www.dataaccess.com/webservicesserver/", Order=0)]
        public SERVICIOWEB.ConversionNumerica.NumberToDollarsRequestBody Body;
        
        public NumberToDollarsRequest() {
        }
        
        public NumberToDollarsRequest(SERVICIOWEB.ConversionNumerica.NumberToDollarsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.dataaccess.com/webservicesserver/")]
    public partial class NumberToDollarsRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public decimal dNum;
        
        public NumberToDollarsRequestBody() {
        }
        
        public NumberToDollarsRequestBody(decimal dNum) {
            this.dNum = dNum;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class NumberToDollarsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="NumberToDollarsResponse", Namespace="http://www.dataaccess.com/webservicesserver/", Order=0)]
        public SERVICIOWEB.ConversionNumerica.NumberToDollarsResponseBody Body;
        
        public NumberToDollarsResponse() {
        }
        
        public NumberToDollarsResponse(SERVICIOWEB.ConversionNumerica.NumberToDollarsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.dataaccess.com/webservicesserver/")]
    public partial class NumberToDollarsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string NumberToDollarsResult;
        
        public NumberToDollarsResponseBody() {
        }
        
        public NumberToDollarsResponseBody(string NumberToDollarsResult) {
            this.NumberToDollarsResult = NumberToDollarsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface NumberConversionSoapTypeChannel : SERVICIOWEB.ConversionNumerica.NumberConversionSoapType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NumberConversionSoapTypeClient : System.ServiceModel.ClientBase<SERVICIOWEB.ConversionNumerica.NumberConversionSoapType>, SERVICIOWEB.ConversionNumerica.NumberConversionSoapType {
        
        public NumberConversionSoapTypeClient() {
        }
        
        public NumberConversionSoapTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NumberConversionSoapTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NumberConversionSoapTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NumberConversionSoapTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SERVICIOWEB.ConversionNumerica.NumberToWordsResponse SERVICIOWEB.ConversionNumerica.NumberConversionSoapType.NumberToWords(SERVICIOWEB.ConversionNumerica.NumberToWordsRequest request) {
            return base.Channel.NumberToWords(request);
        }
        
        public string NumberToWords(ulong ubiNum) {
            SERVICIOWEB.ConversionNumerica.NumberToWordsRequest inValue = new SERVICIOWEB.ConversionNumerica.NumberToWordsRequest();
            inValue.Body = new SERVICIOWEB.ConversionNumerica.NumberToWordsRequestBody();
            inValue.Body.ubiNum = ubiNum;
            SERVICIOWEB.ConversionNumerica.NumberToWordsResponse retVal = ((SERVICIOWEB.ConversionNumerica.NumberConversionSoapType)(this)).NumberToWords(inValue);
            return retVal.Body.NumberToWordsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SERVICIOWEB.ConversionNumerica.NumberToWordsResponse> SERVICIOWEB.ConversionNumerica.NumberConversionSoapType.NumberToWordsAsync(SERVICIOWEB.ConversionNumerica.NumberToWordsRequest request) {
            return base.Channel.NumberToWordsAsync(request);
        }
        
        public System.Threading.Tasks.Task<SERVICIOWEB.ConversionNumerica.NumberToWordsResponse> NumberToWordsAsync(ulong ubiNum) {
            SERVICIOWEB.ConversionNumerica.NumberToWordsRequest inValue = new SERVICIOWEB.ConversionNumerica.NumberToWordsRequest();
            inValue.Body = new SERVICIOWEB.ConversionNumerica.NumberToWordsRequestBody();
            inValue.Body.ubiNum = ubiNum;
            return ((SERVICIOWEB.ConversionNumerica.NumberConversionSoapType)(this)).NumberToWordsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SERVICIOWEB.ConversionNumerica.NumberToDollarsResponse SERVICIOWEB.ConversionNumerica.NumberConversionSoapType.NumberToDollars(SERVICIOWEB.ConversionNumerica.NumberToDollarsRequest request) {
            return base.Channel.NumberToDollars(request);
        }
        
        public string NumberToDollars(decimal dNum) {
            SERVICIOWEB.ConversionNumerica.NumberToDollarsRequest inValue = new SERVICIOWEB.ConversionNumerica.NumberToDollarsRequest();
            inValue.Body = new SERVICIOWEB.ConversionNumerica.NumberToDollarsRequestBody();
            inValue.Body.dNum = dNum;
            SERVICIOWEB.ConversionNumerica.NumberToDollarsResponse retVal = ((SERVICIOWEB.ConversionNumerica.NumberConversionSoapType)(this)).NumberToDollars(inValue);
            return retVal.Body.NumberToDollarsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SERVICIOWEB.ConversionNumerica.NumberToDollarsResponse> SERVICIOWEB.ConversionNumerica.NumberConversionSoapType.NumberToDollarsAsync(SERVICIOWEB.ConversionNumerica.NumberToDollarsRequest request) {
            return base.Channel.NumberToDollarsAsync(request);
        }
        
        public System.Threading.Tasks.Task<SERVICIOWEB.ConversionNumerica.NumberToDollarsResponse> NumberToDollarsAsync(decimal dNum) {
            SERVICIOWEB.ConversionNumerica.NumberToDollarsRequest inValue = new SERVICIOWEB.ConversionNumerica.NumberToDollarsRequest();
            inValue.Body = new SERVICIOWEB.ConversionNumerica.NumberToDollarsRequestBody();
            inValue.Body.dNum = dNum;
            return ((SERVICIOWEB.ConversionNumerica.NumberConversionSoapType)(this)).NumberToDollarsAsync(inValue);
        }
    }
}

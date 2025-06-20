﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Alexis.Dashboard
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="En_MDM_FilePass", Namespace="http://tempuri.org/")]
    public partial class En_MDM_FilePass : object
    {
        
        private string plist_CategoryField;
        
        private string fileNameWithExtensionField;
        
        private byte[] fileContentField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string plist_Category
        {
            get
            {
                return this.plist_CategoryField;
            }
            set
            {
                this.plist_CategoryField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string fileNameWithExtension
        {
            get
            {
                return this.fileNameWithExtensionField;
            }
            set
            {
                this.fileNameWithExtensionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public byte[] fileContent
        {
            get
            {
                return this.fileContentField;
            }
            set
            {
                this.fileContentField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Alexis.Dashboard.File_PassSoap")]
    public interface File_PassSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Plist_Pass", ReplyAction="*")]
        System.Threading.Tasks.Task<Alexis.Dashboard.Plist_PassResponse> Plist_PassAsync(Alexis.Dashboard.Plist_PassRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AppAndPlist_Pass", ReplyAction="*")]
        System.Threading.Tasks.Task<Alexis.Dashboard.AppAndPlist_PassResponse> AppAndPlist_PassAsync(Alexis.Dashboard.AppAndPlist_PassRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Plist_PassRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Plist_Pass", Namespace="http://tempuri.org/", Order=0)]
        public Alexis.Dashboard.Plist_PassRequestBody Body;
        
        public Plist_PassRequest()
        {
        }
        
        public Plist_PassRequest(Alexis.Dashboard.Plist_PassRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Plist_PassRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Alexis.Dashboard.En_MDM_FilePass my_MDM_FilePass;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string tenantDataFolder;
        
        public Plist_PassRequestBody()
        {
        }
        
        public Plist_PassRequestBody(Alexis.Dashboard.En_MDM_FilePass my_MDM_FilePass, string tenantDataFolder)
        {
            this.my_MDM_FilePass = my_MDM_FilePass;
            this.tenantDataFolder = tenantDataFolder;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Plist_PassResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Plist_PassResponse", Namespace="http://tempuri.org/", Order=0)]
        public Alexis.Dashboard.Plist_PassResponseBody Body;
        
        public Plist_PassResponse()
        {
        }
        
        public Plist_PassResponse(Alexis.Dashboard.Plist_PassResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Plist_PassResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool Plist_PassResult;
        
        public Plist_PassResponseBody()
        {
        }
        
        public Plist_PassResponseBody(bool Plist_PassResult)
        {
            this.Plist_PassResult = Plist_PassResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AppAndPlist_PassRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AppAndPlist_Pass", Namespace="http://tempuri.org/", Order=0)]
        public Alexis.Dashboard.AppAndPlist_PassRequestBody Body;
        
        public AppAndPlist_PassRequest()
        {
        }
        
        public AppAndPlist_PassRequest(Alexis.Dashboard.AppAndPlist_PassRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AppAndPlist_PassRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Alexis.Dashboard.En_MDM_FilePass my_MDM_FilePass;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string tenantDataFolder;
        
        public AppAndPlist_PassRequestBody()
        {
        }
        
        public AppAndPlist_PassRequestBody(Alexis.Dashboard.En_MDM_FilePass my_MDM_FilePass, string tenantDataFolder)
        {
            this.my_MDM_FilePass = my_MDM_FilePass;
            this.tenantDataFolder = tenantDataFolder;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AppAndPlist_PassResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AppAndPlist_PassResponse", Namespace="http://tempuri.org/", Order=0)]
        public Alexis.Dashboard.AppAndPlist_PassResponseBody Body;
        
        public AppAndPlist_PassResponse()
        {
        }
        
        public AppAndPlist_PassResponse(Alexis.Dashboard.AppAndPlist_PassResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AppAndPlist_PassResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool AppAndPlist_PassResult;
        
        public AppAndPlist_PassResponseBody()
        {
        }
        
        public AppAndPlist_PassResponseBody(bool AppAndPlist_PassResult)
        {
            this.AppAndPlist_PassResult = AppAndPlist_PassResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public interface File_PassSoapChannel : Alexis.Dashboard.File_PassSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public partial class File_PassSoapClient : System.ServiceModel.ClientBase<Alexis.Dashboard.File_PassSoap>, Alexis.Dashboard.File_PassSoap
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public File_PassSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(File_PassSoapClient.GetBindingForEndpoint(endpointConfiguration), File_PassSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public File_PassSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(File_PassSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public File_PassSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(File_PassSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public File_PassSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Alexis.Dashboard.Plist_PassResponse> Alexis.Dashboard.File_PassSoap.Plist_PassAsync(Alexis.Dashboard.Plist_PassRequest request)
        {
            return base.Channel.Plist_PassAsync(request);
        }
        
        public System.Threading.Tasks.Task<Alexis.Dashboard.Plist_PassResponse> Plist_PassAsync(Alexis.Dashboard.En_MDM_FilePass my_MDM_FilePass, string tenantDataFolder)
        {
            Alexis.Dashboard.Plist_PassRequest inValue = new Alexis.Dashboard.Plist_PassRequest();
            inValue.Body = new Alexis.Dashboard.Plist_PassRequestBody();
            inValue.Body.my_MDM_FilePass = my_MDM_FilePass;
            inValue.Body.tenantDataFolder = tenantDataFolder;
            return ((Alexis.Dashboard.File_PassSoap)(this)).Plist_PassAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Alexis.Dashboard.AppAndPlist_PassResponse> Alexis.Dashboard.File_PassSoap.AppAndPlist_PassAsync(Alexis.Dashboard.AppAndPlist_PassRequest request)
        {
            return base.Channel.AppAndPlist_PassAsync(request);
        }
        
        public System.Threading.Tasks.Task<Alexis.Dashboard.AppAndPlist_PassResponse> AppAndPlist_PassAsync(Alexis.Dashboard.En_MDM_FilePass my_MDM_FilePass, string tenantDataFolder)
        {
            Alexis.Dashboard.AppAndPlist_PassRequest inValue = new Alexis.Dashboard.AppAndPlist_PassRequest();
            inValue.Body = new Alexis.Dashboard.AppAndPlist_PassRequestBody();
            inValue.Body.my_MDM_FilePass = my_MDM_FilePass;
            inValue.Body.tenantDataFolder = tenantDataFolder;
            return ((Alexis.Dashboard.File_PassSoap)(this)).AppAndPlist_PassAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.File_PassSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.File_PassSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpsTransportBindingElement httpsBindingElement = new System.ServiceModel.Channels.HttpsTransportBindingElement();
                httpsBindingElement.AllowCookies = true;
                httpsBindingElement.MaxBufferSize = int.MaxValue;
                httpsBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpsBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.File_PassSoap))
            {
                return new System.ServiceModel.EndpointAddress("https://cloud.emerico.biz/IOS_MDM_Multi_File_Pass/File_Pass.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.File_PassSoap12))
            {
                return new System.ServiceModel.EndpointAddress("https://cloud.emerico.biz/IOS_MDM_Multi_File_Pass/File_Pass.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            File_PassSoap,
            
            File_PassSoap12,
        }
    }
}

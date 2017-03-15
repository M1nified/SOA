﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SpaceClient.ServiceReferenceBlackHole {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceBlackHole.IBlackHole")]
    public interface IBlackHole {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlackHole/PullStarship", ReplyAction="http://tempuri.org/IBlackHole/PullStarshipResponse")]
        Space.Starship PullStarship(Space.Starship ship);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlackHole/PullStarship", ReplyAction="http://tempuri.org/IBlackHole/PullStarshipResponse")]
        System.Threading.Tasks.Task<Space.Starship> PullStarshipAsync(Space.Starship ship);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlackHole/UltimateAnswer", ReplyAction="http://tempuri.org/IBlackHole/UltimateAnswerResponse")]
        string UltimateAnswer();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBlackHole/UltimateAnswer", ReplyAction="http://tempuri.org/IBlackHole/UltimateAnswerResponse")]
        System.Threading.Tasks.Task<string> UltimateAnswerAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBlackHoleChannel : SpaceClient.ServiceReferenceBlackHole.IBlackHole, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BlackHoleClient : System.ServiceModel.ClientBase<SpaceClient.ServiceReferenceBlackHole.IBlackHole>, SpaceClient.ServiceReferenceBlackHole.IBlackHole {
        
        public BlackHoleClient() {
        }
        
        public BlackHoleClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BlackHoleClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BlackHoleClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BlackHoleClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Space.Starship PullStarship(Space.Starship ship) {
            return base.Channel.PullStarship(ship);
        }
        
        public System.Threading.Tasks.Task<Space.Starship> PullStarshipAsync(Space.Starship ship) {
            return base.Channel.PullStarshipAsync(ship);
        }
        
        public string UltimateAnswer() {
            return base.Channel.UltimateAnswer();
        }
        
        public System.Threading.Tasks.Task<string> UltimateAnswerAsync() {
            return base.Channel.UltimateAnswerAsync();
        }
    }
}
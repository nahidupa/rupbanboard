﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rupban.ServiceAgent.RupbanBoardService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Code.google.com/p/rupbanboard", ConfigurationName="RupbanBoardService.IRupbanBoardService", CallbackContract=typeof(Rupban.ServiceAgent.RupbanBoardService.IRupbanBoardServiceCallback))]
    public interface IRupbanBoardService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Code.google.com/p/rupbanboard/IRupbanBoardService/MoveTicket", ReplyAction="http://Code.google.com/p/rupbanboard/IRupbanBoardService/MoveTicketResponse")]
        void MoveTicket();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Code.google.com/p/rupbanboard/IRupbanBoardService/Subscribe", ReplyAction="http://Code.google.com/p/rupbanboard/IRupbanBoardService/SubscribeResponse")]
        bool Subscribe();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Code.google.com/p/rupbanboard/IRupbanBoardService/Unsubscribe", ReplyAction="http://Code.google.com/p/rupbanboard/IRupbanBoardService/UnsubscribeResponse")]
        bool Unsubscribe();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Code.google.com/p/rupbanboard/IRupbanBoardService/ViewTicketHistory", ReplyAction="http://Code.google.com/p/rupbanboard/IRupbanBoardService/ViewTicketHistoryRespons" +
            "e")]
        void ViewTicketHistory();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Code.google.com/p/rupbanboard/IRupbanBoardService/GetCurrentProjectList", ReplyAction="http://Code.google.com/p/rupbanboard/IRupbanBoardService/GetCurrentProjectListRes" +
            "ponse")]
        Rupban.Core.Project[] GetCurrentProjectList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Code.google.com/p/rupbanboard/IRupbanBoardService/GetTemplateCollumList", ReplyAction="http://Code.google.com/p/rupbanboard/IRupbanBoardService/GetTemplateCollumListRes" +
            "ponse")]
        Rupban.Core.TemplateColumn[] GetTemplateCollumList();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRupbanBoardServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Code.google.com/p/rupbanboard/IRupbanBoardService/TicketMoved")]
        void TicketMoved();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRupbanBoardServiceChannel : Rupban.ServiceAgent.RupbanBoardService.IRupbanBoardService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RupbanBoardServiceClient : System.ServiceModel.DuplexClientBase<Rupban.ServiceAgent.RupbanBoardService.IRupbanBoardService>, Rupban.ServiceAgent.RupbanBoardService.IRupbanBoardService {
        
        public RupbanBoardServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public RupbanBoardServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public RupbanBoardServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public RupbanBoardServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public RupbanBoardServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void MoveTicket() {
            base.Channel.MoveTicket();
        }
        
        public bool Subscribe() {
            return base.Channel.Subscribe();
        }
        
        public bool Unsubscribe() {
            return base.Channel.Unsubscribe();
        }
        
        public void ViewTicketHistory() {
            base.Channel.ViewTicketHistory();
        }
        
        public Rupban.Core.Project[] GetCurrentProjectList() {
            return base.Channel.GetCurrentProjectList();
        }
        
        public Rupban.Core.TemplateColumn[] GetTemplateCollumList() {
            return base.Channel.GetTemplateCollumList();
        }
    }
}

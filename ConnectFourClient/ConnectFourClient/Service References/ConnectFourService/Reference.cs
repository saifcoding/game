﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConnectFourClient.ConnectFourService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserExistsFault", Namespace="http://schemas.datacontract.org/2004/07/ConnectFourServer")]
    [System.SerializableAttribute()]
    public partial class UserExistsFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UserAlreadyLoggedInFault", Namespace="http://schemas.datacontract.org/2004/07/ConnectFourServer")]
    [System.SerializableAttribute()]
    public partial class UserAlreadyLoggedInFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UserNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/ConnectFourServer")]
    [System.SerializableAttribute()]
    public partial class UserNotFoundFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ConnectFourService.IConnectFourService", CallbackContract=typeof(ConnectFourClient.ConnectFourService.IConnectFourServiceCallback))]
    public interface IConnectFourService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConnectFourService/register", ReplyAction="http://tempuri.org/IConnectFourService/registerResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ConnectFourClient.ConnectFourService.UserExistsFault), Action="http://tempuri.org/IConnectFourService/registerUserExistsFaultFault", Name="UserExistsFault", Namespace="http://schemas.datacontract.org/2004/07/ConnectFourServer")]
        void register(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConnectFourService/register", ReplyAction="http://tempuri.org/IConnectFourService/registerResponse")]
        System.Threading.Tasks.Task registerAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConnectFourService/login", ReplyAction="http://tempuri.org/IConnectFourService/loginResponse")]
        bool login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConnectFourService/login", ReplyAction="http://tempuri.org/IConnectFourService/loginResponse")]
        System.Threading.Tasks.Task<bool> loginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConnectFourService/Connect", ReplyAction="http://tempuri.org/IConnectFourService/ConnectResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ConnectFourClient.ConnectFourService.UserAlreadyLoggedInFault), Action="http://tempuri.org/IConnectFourService/ConnectUserAlreadyLoggedInFaultFault", Name="UserAlreadyLoggedInFault", Namespace="http://schemas.datacontract.org/2004/07/ConnectFourServer")]
        void Connect(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConnectFourService/Connect", ReplyAction="http://tempuri.org/IConnectFourService/ConnectResponse")]
        System.Threading.Tasks.Task ConnectAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConnectFourService/Disconnect", ReplyAction="http://tempuri.org/IConnectFourService/DisconnectResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ConnectFourClient.ConnectFourService.UserNotFoundFault), Action="http://tempuri.org/IConnectFourService/DisconnectUserNotFoundFaultFault", Name="UserNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/ConnectFourServer")]
        void Disconnect(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConnectFourService/Disconnect", ReplyAction="http://tempuri.org/IConnectFourService/DisconnectResponse")]
        System.Threading.Tasks.Task DisconnectAsync(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConnectFourService/SendRequestForGameToUser", ReplyAction="http://tempuri.org/IConnectFourService/SendRequestForGameToUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ConnectFourClient.ConnectFourService.UserNotFoundFault), Action="http://tempuri.org/IConnectFourService/SendRequestForGameToUserUserNotFoundFaultF" +
            "ault", Name="UserNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/ConnectFourServer")]
        void SendRequestForGameToUser(string opponentUserName, string myUserName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConnectFourService/SendRequestForGameToUser", ReplyAction="http://tempuri.org/IConnectFourService/SendRequestForGameToUserResponse")]
        System.Threading.Tasks.Task SendRequestForGameToUserAsync(string opponentUserName, string myUserName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConnectFourService/SendAcceptForGameToUser", ReplyAction="http://tempuri.org/IConnectFourService/SendAcceptForGameToUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ConnectFourClient.ConnectFourService.UserNotFoundFault), Action="http://tempuri.org/IConnectFourService/SendAcceptForGameToUserUserNotFoundFaultFa" +
            "ult", Name="UserNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/ConnectFourServer")]
        void SendAcceptForGameToUser(string opponentUserName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConnectFourService/SendAcceptForGameToUser", ReplyAction="http://tempuri.org/IConnectFourService/SendAcceptForGameToUserResponse")]
        System.Threading.Tasks.Task SendAcceptForGameToUserAsync(string opponentUserName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConnectFourService/SendRejectForGameToUser", ReplyAction="http://tempuri.org/IConnectFourService/SendRejectForGameToUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ConnectFourClient.ConnectFourService.UserNotFoundFault), Action="http://tempuri.org/IConnectFourService/SendRejectForGameToUserUserNotFoundFaultFa" +
            "ult", Name="UserNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/ConnectFourServer")]
        void SendRejectForGameToUser(string opponentUserName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConnectFourService/SendRejectForGameToUser", ReplyAction="http://tempuri.org/IConnectFourService/SendRejectForGameToUserResponse")]
        System.Threading.Tasks.Task SendRejectForGameToUserAsync(string opponentUserName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConnectFourService/InitGame", ReplyAction="http://tempuri.org/IConnectFourService/InitGameResponse")]
        void InitGame(string player1, string player2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConnectFourService/InitGame", ReplyAction="http://tempuri.org/IConnectFourService/InitGameResponse")]
        System.Threading.Tasks.Task InitGameAsync(string player1, string player2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConnectFourService/IsMyTurn", ReplyAction="http://tempuri.org/IConnectFourService/IsMyTurnResponse")]
        bool IsMyTurn(string playerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConnectFourService/IsMyTurn", ReplyAction="http://tempuri.org/IConnectFourService/IsMyTurnResponse")]
        System.Threading.Tasks.Task<bool> IsMyTurnAsync(string playerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConnectFourService/Insert", ReplyAction="http://tempuri.org/IConnectFourService/InsertResponse")]
        int Insert(int column, string playerName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConnectFourService/Insert", ReplyAction="http://tempuri.org/IConnectFourService/InsertResponse")]
        System.Threading.Tasks.Task<int> InsertAsync(int column, string playerName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IConnectFourServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IConnectFourService/UpdateClientsList")]
        void UpdateClientsList(string[] users);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IConnectFourService/sendGameRequestToUser")]
        void sendGameRequestToUser(string fromUser);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IConnectFourService/sendAcceptRequestToUser")]
        void sendAcceptRequestToUser();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IConnectFourService/sendRejectRequestToUser")]
        void sendRejectRequestToUser();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IConnectFourService/updateCell")]
        void updateCell(int row, int col);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IConnectFourService/annouceWinner")]
        void annouceWinner(string username);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IConnectFourServiceChannel : ConnectFourClient.ConnectFourService.IConnectFourService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ConnectFourServiceClient : System.ServiceModel.DuplexClientBase<ConnectFourClient.ConnectFourService.IConnectFourService>, ConnectFourClient.ConnectFourService.IConnectFourService {
        
        public ConnectFourServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ConnectFourServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ConnectFourServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ConnectFourServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ConnectFourServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void register(string username, string password) {
            base.Channel.register(username, password);
        }
        
        public System.Threading.Tasks.Task registerAsync(string username, string password) {
            return base.Channel.registerAsync(username, password);
        }
        
        public bool login(string username, string password) {
            return base.Channel.login(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> loginAsync(string username, string password) {
            return base.Channel.loginAsync(username, password);
        }
        
        public void Connect(string username) {
            base.Channel.Connect(username);
        }
        
        public System.Threading.Tasks.Task ConnectAsync(string username) {
            return base.Channel.ConnectAsync(username);
        }
        
        public void Disconnect(string userName) {
            base.Channel.Disconnect(userName);
        }
        
        public System.Threading.Tasks.Task DisconnectAsync(string userName) {
            return base.Channel.DisconnectAsync(userName);
        }
        
        public void SendRequestForGameToUser(string opponentUserName, string myUserName) {
            base.Channel.SendRequestForGameToUser(opponentUserName, myUserName);
        }
        
        public System.Threading.Tasks.Task SendRequestForGameToUserAsync(string opponentUserName, string myUserName) {
            return base.Channel.SendRequestForGameToUserAsync(opponentUserName, myUserName);
        }
        
        public void SendAcceptForGameToUser(string opponentUserName) {
            base.Channel.SendAcceptForGameToUser(opponentUserName);
        }
        
        public System.Threading.Tasks.Task SendAcceptForGameToUserAsync(string opponentUserName) {
            return base.Channel.SendAcceptForGameToUserAsync(opponentUserName);
        }
        
        public void SendRejectForGameToUser(string opponentUserName) {
            base.Channel.SendRejectForGameToUser(opponentUserName);
        }
        
        public System.Threading.Tasks.Task SendRejectForGameToUserAsync(string opponentUserName) {
            return base.Channel.SendRejectForGameToUserAsync(opponentUserName);
        }
        
        public void InitGame(string player1, string player2) {
            base.Channel.InitGame(player1, player2);
        }
        
        public System.Threading.Tasks.Task InitGameAsync(string player1, string player2) {
            return base.Channel.InitGameAsync(player1, player2);
        }
        
        public bool IsMyTurn(string playerName) {
            return base.Channel.IsMyTurn(playerName);
        }
        
        public System.Threading.Tasks.Task<bool> IsMyTurnAsync(string playerName) {
            return base.Channel.IsMyTurnAsync(playerName);
        }
        
        public int Insert(int column, string playerName) {
            return base.Channel.Insert(column, playerName);
        }
        
        public System.Threading.Tasks.Task<int> InsertAsync(int column, string playerName) {
            return base.Channel.InsertAsync(column, playerName);
        }
    }
}

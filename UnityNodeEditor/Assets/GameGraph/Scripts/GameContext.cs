using System;
using UniRx;

[Serializable]
public class GameContext : IGameContext{
    
    public IMessageBroker MessageBroker { get; }
    
}

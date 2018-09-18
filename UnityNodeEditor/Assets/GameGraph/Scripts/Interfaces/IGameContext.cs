using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public interface IGameContext  {

    IMessageBroker MessageBroker { get; }
    
}

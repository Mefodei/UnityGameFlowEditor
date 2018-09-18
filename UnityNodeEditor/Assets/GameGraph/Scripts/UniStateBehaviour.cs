using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Tools.StateMachine;
using UnityEngine;

[CreateAssetMenu(menuName = "GameGraph/GameState",fileName = "GameState")]
public class UniStateBehaviour : ScriptableObject, IStateBehaviour<IEnumerator> {
	
	
	public IEnumerator Execute()
	{
		yield break;
	}

	public void Stop()
	{
		
	}

	public void Dispose()
	{
		
	}
}

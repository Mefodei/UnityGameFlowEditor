using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Extensions;
using Assets.Scripts.Tools.StateMachine;
using UnityEngine;

[CreateAssetMenu(menuName = "GameGraph/GameState",fileName = "GameState")]
public class UniStateBehaviour : ScriptableObject, IStateBehaviour<IEnumerator>
{
	private IGameContext _context;
	
	public void Initialize(IGameContext context)
	{
		_context = context;
	}
	
	protected List<IDisposable> _disposables;
	
	public IEnumerator Execute()
	{
		yield break;
	}

	public void Stop()
	{
		Dispose();
	}

	public virtual void Dispose()
	{
		_disposables.Cancel();
	}
	
}

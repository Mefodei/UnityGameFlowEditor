using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

namespace GameGraphModule
{
	[Serializable]
	public class GameStateNode : Node
	{
		
		[Input] public GameContext InContext;
		[Output] public GameContext OutContext;
		
		
	}
}

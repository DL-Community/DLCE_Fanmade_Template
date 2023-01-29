using System;
using DancingLine.Level.Triggers;
using UnityEngine;

namespace DancingLine.Level
{
	public class ObstacleContainer : MonoBehaviour
	{
		public void Start()
		{
			Init();
		}
		public void RestartObstacles()
		{
			Init();
			for (var i = 0; i < _triggers.Length; i++)
			{
				_triggers[i].ResetTrigger();
			}
		}
		
		public Trigger[] Triggers => _triggers;
		
		Trigger[] _triggers;
		bool _initialized;
		public void Init()
		{
			if (!_initialized)
			{
				_triggers = GetComponentsInChildren<Trigger>(true);
			}
		}
	}
}

using System;
using DancingLine.Character;
using UnityEngine;
using DancingLine.Level.Animations;
using DancingLine.Level;

namespace DancingLine.GameCamera
{
	public class CameraFollower : ObjectFollower
	{
		public static bool FollowHero = true;
		static CameraFollower instance;
		public static CameraFollower Instance
		{
			get
			{
				if (instance == null)
				{
					instance = FindObjectOfType<CameraFollower>();
				}
				return instance;
			}
		}
		protected override void Update()
		{
            if (FollowHero)
                base.Update();
        }
	}

}

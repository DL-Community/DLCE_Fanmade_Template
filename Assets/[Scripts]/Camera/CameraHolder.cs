using UnityEngine;
using DancingLine.Level.Animations;

namespace DancingLine.GameCamera
{
	public class CameraHolder : ObjectFollower
	{
        protected override void Update()
        {
            UpdateFollower();
        }

        #region Follow
        public static bool FollowHero = true;
        void UpdateFollower()
        {
            if(FollowHero) 
                base.Update();
        }
        #endregion


    }

}

using DancingLine.Level.Animations;

namespace DancingLine.GameCamera
{
	public sealed class CameraFollower : ObjectFollower
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

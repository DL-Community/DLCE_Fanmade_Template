using DancingLine.Singleton;
using UnityEngine;

namespace DancingLine.Character
{
    public class GameCharacter : MonoBehaviourSingleton<GameCharacter>
    {
        public Hero HeroObject;
        public void SetPosition(Vector3 pos)
        {
            transform.position = pos;
            HeroObject.SetPosition(pos);
        }
        //todo:角色开始/重置/KILL（停止）功能
    }
    
}

using DancingLine.Singleton;
using UnityEngine;

namespace DancingLine.Character
{
    public class GameCharacter : MonoBehaviourSingleton<GameCharacter>
    {
        public Hero HeroObject;
        public GameObject LinePool;
        public GameObject LiveLines;
        LineContainer _currentLine;
        public enum DIRECTION
        {
            Right,
            Left,
            Straight
        }
        public void Init(Vector3 pos, DIRECTION dir)
        {
            SetPosition(pos);
            LinePool.SetActive(false);
        }
        public void SetPosition(Vector3 pos)
        {
            transform.position = pos;
            HeroObject.SetPosition(pos);
        }

        DIRECTION _direction;
        public DIRECTION Direction
        {
            get => _direction;
            set
            {
                _direction = value;
                UpdateTailDirection();
            }
        }

        public Vector3 EulerDirection
        {
            get
            {
                return Direction switch
                {
                    DIRECTION.Left => HeroObject.leftDirection,
                    DIRECTION.Right => HeroObject.rightDirection,
                    DIRECTION.Straight => HeroObject.straightDirection,
                    _ => Vector3.zero
                };
            }
        }
        void UpdateTailDirection()
        {
            
        }
        //todo:角色开始/重置/KILL（停止）功能
    }
    
}

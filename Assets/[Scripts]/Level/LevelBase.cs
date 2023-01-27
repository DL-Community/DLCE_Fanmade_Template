using DancingLine.Singleton;
using UnityEngine;

namespace DancingLine.Level
{
    public class LevelBase : MonoBehaviourSingleton<LevelBase>
    {
        [Tooltip("关卡速度 (Time Scale)")]
        public float LevelSpeed = 1f;

        [Tooltip("线头的速度，默认12")]
        public float HeroSpeed = 12f;

        [Tooltip("关卡名")]
        public string Name = "Level Name";

        [Tooltip("用于保存关卡进度的名称")]
        public string DataName = "LevelDataName";
    }
}

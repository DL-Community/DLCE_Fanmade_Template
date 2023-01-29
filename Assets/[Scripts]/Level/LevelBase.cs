using DancingLine.Character;
using DancingLine.Singleton;
using UnityEngine;

#nullable enable

namespace DancingLine.Level
{
    public class LevelBase : MonoBehaviourSingleton<LevelBase>
    {
        [Header("关卡速度 (Time Scale)")]
        public float LevelSpeed = 1f;

        [Header("线头的速度，默认12")]
        public float HeroSpeed = 12f;

        [Header("关卡名")]
        public string Name = "Level Name";

        public PlayerPosition StartPosition;
        PlayerPosition _initStartPosition;
        
        public string DataName => Name.Replace(" ", "_");

        #region Diamond Data

        string? _diamondDataName;
        string DiamondDataName => _diamondDataName ??= $"{DataName}checkpointsReached";

        public int DiamondsCollected
        {
            get => Mathf.Min(UserDataManager.LoadInt(DiamondDataName), 10);
            set => UserDataManager.Save(DiamondDataName, value);
        }
        #endregion


        #region Stars Data
        
        string? _starsDataName;
        string StarsDataName => _starsDataName ??= $"{DataName}_StarsCollectedDataName";
        
        public int StarsCollected
        {
            get => Mathf.Min(UserDataManager.LoadInt(StarsDataName), 3) ;
            set => UserDataManager.Save(StarsDataName, value);
        }
        #endregion
        
        //TODO 关卡初始化
        //TODO 关卡重置
        
        void Start()
        {
            Reset();
        }

        public void Reset()
        {
            Init();
        }
        
        public GameCharacter Character => GameCharacter.Instance;
        public static bool Initialized { get; private set; }
        void Init()
        {
            InitCharacters();
            InitCamera();
            CollectLoadedObjects();
            Initialized = true;
        }
        
        void InitCharacters()
        {
            _initStartPosition = StartPosition;
            Character.Init(_initStartPosition.PlayerPositions[0].position, _initStartPosition.Direction);
        }

        void InitCamera()
        {
            
        }

        
        void CollectLoadedObjects()
        {
            
        }
    }
}

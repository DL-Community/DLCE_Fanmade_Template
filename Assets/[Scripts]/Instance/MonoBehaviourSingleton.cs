using Unity.VisualScripting;
using UnityEngine;
namespace DancingLine.Singleton
{
    /// <summary>
    /// 单例
    /// </summary>
    /// <typeparam name="T">类型</typeparam>
    public class MonoBehaviourSingleton<T> : MonoBehaviour where T : MonoBehaviour 
	{
		protected static T _instance;
		public static T Instance
		{
			get
			{
				if (!_instance)
				{
                    _instance = FindObjectOfType<T>() ?? NewInstance();
                }
				return _instance;
			}
		}
		static string TypeName => typeof(T).Name;
        static T NewInstance()
        {
	        var typeName = TypeName;
            var instance = new GameObject($"[Instance] {typeName}" ).AddComponent<T>();
            
            Debug.Log($"Creating instance of {typeName}", instance);
			return instance;
        }
	}
}

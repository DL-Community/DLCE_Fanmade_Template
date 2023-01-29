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
		public static T Instance => _instance ??= FindObjectOfType<T>() ?? GetNewInstance();

		static string TypeName => typeof(T).Name;
        static T GetNewInstance()
        {
	        var typeName = TypeName;
            var instance = new GameObject($"[Instance] {typeName}" ).AddComponent<T>();
            
            Debug.Log($"Creating instance of {typeName}", instance);
			return instance;
        }
	}
}

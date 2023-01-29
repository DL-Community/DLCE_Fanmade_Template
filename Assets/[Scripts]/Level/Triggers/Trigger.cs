using DancingLine.Character;
using UnityEngine;
using UnityEngine.Events;

namespace DancingLine.Level.Triggers
{
	public interface ITriggerable
	{
		void OnTriggered(Trigger trigger);
	}
	
    public abstract class Trigger : MonoBehaviour
	{
		void Start()
		{
			_boxCollider = GetComponent<BoxCollider>();
			if (_boxCollider == null)
				_boxCollider = gameObject.AddComponent<BoxCollider>();
			
			_boxCollider.isTrigger = true;
		}
		public bool Enabled { get; protected set; }

		public virtual void ResetTrigger()
		{
			Enabled = true;
		}
		
		
		void OnTriggerEnter(Collider col)
		{
			if (Enabled && col.gameObject.GetComponent<Hero>() != null)
			{
				Enabled = false;

				var triggerables = TrigerableContainer.GetComponentsInChildren<ITriggerable>();
				for (var i = 0; i < triggerables.Length; i++)
				{
					triggerables[i]?.OnTriggered(this);
				}
				
				OnTriggered(col);
				Event?.Invoke();
			}
		}

		protected abstract void OnTriggered(Collider col);

		//这些成员仅用于和官方模板保持一致
		[Tooltip("这个物体中包含的所有继承了ITrigerable的脚本都会被触发")] 
		public GameObject TrigerableContainer;
		public UnityEvent Event;
		BoxCollider _boxCollider;
	}
}

using UnityEngine;

namespace DancingLine.Character
{
    public class Hero : MonoBehaviour
    {
        public GameObject Head;
        public Vector3 leftDirection;
        public Vector3 rightDirection;
        public Vector3 straightDirection;
        public Vector3 startPosition;
        public Collider HeadCollider;
        public Collider BottomCollider;
        public bool isDied;
        
        Rigidbody _rigidbody;
        Rigidbody Rigidbody => _rigidbody ??= GetComponent<Rigidbody>();

        public static float Speed { get; set; } = 12;


        public void SetPosition(Vector3 pos)
        {
            ResetRigidBody();
            transform.position = pos;
            isDied = false;
        }

        public void ResetRigidBody()
        {
            UseKinematic(true);
            Rigidbody.angularVelocity = Vector3.zero;
            Rigidbody.velocity = Vector3.zero;
        }
        public void UseKinematic(bool flag)
        {
            Rigidbody.isKinematic = flag;
            HeadCollider.enabled = !flag;
        }
        //TODO:线头的开始和停止功能
        //TODO:线头的撞墙判定
        //TODO:Raycast落地检测
    }
    
}

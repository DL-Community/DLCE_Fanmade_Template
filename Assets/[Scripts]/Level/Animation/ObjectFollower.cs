using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DancingLine.Level.Animations
{
    public class ObjectFollower : MonoBehaviour
    {
        protected virtual void Update()
        {
            var moveVec = target.position + offset - follower.position;
            if (!StayConst)
            {
                var fwd = moveVec * Time.smoothDeltaTime;
                fwd.Scale(LerpSpeed);

                follower.Translate(fwd);
            }
            else
            {
                follower.Translate(moveVec);
            }
        }

        public Transform target;
        public Transform follower;
        public Vector3 LerpSpeed = new Vector3(1f, 1f, 1f);
        public Vector3 offset;
        public bool StayConst;
    }

}

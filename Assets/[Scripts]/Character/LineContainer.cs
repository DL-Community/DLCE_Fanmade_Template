using DancingLine;
using UnityEngine;

namespace DancingLine.Character
{
    public class LineContainer : MonoBehaviour
    {
	    public GameObject Box;
	    public GameObject Ending;
		Transform Trans { get; set; }
		public void Init()
		{
			Trans = transform;
			_boxRenderer = Box.GetComponent<Renderer>();
			_endingRenderer = Ending.GetComponent<Renderer>();
			_boxTransform = Box.transform;
			_endingTransform = Ending.transform;
		}

		public void SetRotation(Vector3 rot)
		{
			Trans.localEulerAngles = rot;
		}

		public void SetPosition(Vector3 pos)
		{
			Trans.localPosition = pos;
			BoxTransform.localPosition = Vector3.zero;
			EndingTransform.localPosition = Vector3.zero;
		}

		public void ScaleBox(Vector3 headLocalPos)
		{
			var dist = Vector3.Distance(Trans.localPosition, headLocalPos);
			
			BoxTransform.localScale = new Vector3(1f, 1f, dist);
			
			if (dist < 0.1f && Box.gameObject.activeSelf)
				Box.SetActive(false);
			
			else if (!Box.gameObject.activeSelf)
				Box.SetActive(true);
		}
		
		
		Renderer _boxRenderer;
		public Renderer BoxRenderer => _boxRenderer ??= Box.GetComponent<Renderer>();
		
		Renderer _endingRenderer;
		public Renderer EndingRenderer => _endingRenderer ??= Ending.GetComponent<Renderer>();

		Transform _boxTransform;
		public Transform BoxTransform => _boxTransform ??= Box.transform;
		
		Transform _endingTransform;
		public Transform EndingTransform => _endingTransform ??= Ending.transform;
    }
}

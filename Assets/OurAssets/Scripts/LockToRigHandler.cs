using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class LockToRigHandler : MonoBehaviour {
	
	public Transform rigTarget;

	// Update is called once per frame
#if UNITY_EDITOR
	void Update () {
		transform.position = rigTarget.position;
		//transform.rotation = rigTarget.rotation;
	}
#endif
}

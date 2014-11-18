using UnityEngine;
using System.Collections;

public class ARRigController : MonoBehaviour {
	

	public Transform rigTarget;
	
	// Update is called once per frame
	void Update () {
		rigTarget.position = transform.position;
		//rigTarget.rotation = transform.rotation;
	}
}

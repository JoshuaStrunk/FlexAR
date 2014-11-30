using UnityEngine;
using System.Collections;

public class ARRigController : MonoBehaviour {
	
	public bool setPos = false;
	public bool setRot = false;

	Quaternion prevRot;


	public Transform rigTarget;
	void Start() {
		prevRot = transform.rotation;
	}
	// Update is called once per frame
	void Update () {
		if(setPos)
			rigTarget.position = transform.position;
		if(setRot) {
			//rigTarget.localRotation = transform.localRotation;
			//rigTarget.localRotation = transform.rotation;
			rigTarget.rotation = transform.rotation;
		}
	}
}

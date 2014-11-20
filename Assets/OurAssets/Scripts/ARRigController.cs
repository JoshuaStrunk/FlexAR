using UnityEngine;
using System.Collections;

public class ARRigController : MonoBehaviour {
	
	public bool setPos = false;
	public bool setRot = false;


	public Transform rigTarget;
	
	// Update is called once per frame
	void Update () {
		if(setPos)
			rigTarget.position = transform.position;
		if(setRot)
			rigTarget.rotation = transform.rotation;
	}
}

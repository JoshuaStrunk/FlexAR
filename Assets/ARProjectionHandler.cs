using UnityEngine;
using System.Collections;

public class ARProjectionHandler : MonoBehaviour {

	public GameObject armRoot;

	// Update is called once per frame
	void Update () {

		//Check if any image targets are active if so set armRoot to be active
		bool activeCheck = false;
		foreach(Transform child in transform) {
			//Have to first get this objects children which are the image targets then check there empty child game objects to see if they are active.
			if(child.gameObject.transform.GetChild(0).gameObject.activeInHierarchy ){
				activeCheck = true;
			}
		}
		armRoot.SetActive(activeCheck);
	}
}

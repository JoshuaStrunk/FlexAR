using UnityEngine;
using System.Collections;

public class MuscleAnimationController : MonoBehaviour {

	public float percentMod = 100f;

	public GameObject[] abductionObj; 
	public GameObject[] adductionObj;
	public GameObject[] anteriorObj;
	public GameObject[] posteriorObj;
	/*
	public GameObject[] anteriorlyObj;
	public GameObject[] posteriorlyObj;
	*/
	SkinnedMeshRenderer[] abduction; 
	SkinnedMeshRenderer[] adduction;
	SkinnedMeshRenderer[] anterior;
	SkinnedMeshRenderer[] posterior;
	/*
	SkinnedMeshRenderer[] anteriorly;
	SkinnedMeshRenderer[] posteriorly;
	*/
	public int[] abductionIndex;
	public int[] adductionIndex;
	public int[] anteriorIndex;
	public int[] posteriorIndex;
	/*
	public int[] anteriorlyIndex;
	public int[] posteriorlyIndex;
	*/

	// Use this for initialization
	void Start () {
		abduction = new SkinnedMeshRenderer[abductionObj.Length];
		for(int i=0; i<abductionObj.Length; i++) {
			abduction[i] = abductionObj[i].GetComponent<SkinnedMeshRenderer>();
		}
		adduction = new SkinnedMeshRenderer[adductionObj.Length];
		for(int i=0; i<adductionObj.Length; i++) {
			adduction[i] = adductionObj[i].GetComponent<SkinnedMeshRenderer>();
		}
		anterior = new SkinnedMeshRenderer[anteriorObj.Length];
		for(int i=0; i<anteriorObj.Length; i++) {
			anterior[i] = anteriorObj[i].GetComponent<SkinnedMeshRenderer>();
		}
		posterior = new SkinnedMeshRenderer[posteriorObj.Length];
		for(int i=0; i<posteriorObj.Length; i++) {
			posterior[i] = posteriorObj[i].GetComponent<SkinnedMeshRenderer>();
		}
	}
	
	// Update is called once per frame
	void Update () {
		animate (abduction, abductionIndex, abductionCalc());
		animate (adduction, adductionIndex, adductionCalc());
		animate (anterior, anteriorIndex, anteriorCalc());
		animate (posterior, posteriorIndex, posteriorCalc());
		/*
		animate (anteriorly, anteriorlyIndex, anteriorlyCalc());
		animate(posteriorly, posteriorlyIndex, posteriorlyCalc());
		*/
	}

	//Array of SkinnedMeshRenderers and indexes to needed blendshapes with the value to set the blendshape too
	void animate(SkinnedMeshRenderer[] obj, int[] index, float value) {
		for(int i=0; i<obj.Length; i++){
			obj[i].SetBlendShapeWeight(index[i], value);
		}
	}

	float abductionCalc() {
		float ret = 0;
		ret = transform.localEulerAngles.z;
		if(ret < 85) {
			ret -= 85;
			ret = Mathf.Abs(ret);
			ret /= 170f;
		}
		else if(ret > 150){
			ret -= 360;
			ret = Mathf.Abs(ret);
			ret += 85;
			ret /= 170f;
		}
		else {
			ret = 0;
		}
		return ret * percentMod;
	}
	float adductionCalc() {
		float ret = 0;
		ret = transform.localEulerAngles.z;
		if(ret >= 85 & ret <= 150) {
			ret -= 80;
			ret /= 40;
		}
		else {
			ret =0 * percentMod;
		}
		return ret;
	}
	float anteriorCalc() {
		float ret = 0;
		ret = transform.localEulerAngles.x;
		if(ret > 150) {
			ret = 360 - ret; //get difference
			ret /= 60f; //percentMod% would be 60;
		}
		else {
			ret = 0;
		}
		return ret * percentMod;
	}
	float posteriorCalc() {
		float ret = 0;
		ret = transform.localEulerAngles.x;
		if(ret <= 150) {

			ret /= 60f; //percentMod% would be 60;
		}
		else {
			ret = 0;
		}
		return ret * percentMod;
	}
	/*
	float anteriorlyCalc() {
		float ret = 0;
		ret = transform.localEulerAngles.z;
		if() {
		}
		else {
		}
		return 0;
	}
	float posteriorlyCalc() {
		float ret = 0;
		ret = transform.localEulerAngles.z;
		if() {
		}
		else {
		}
		return 0;
	}
	*/
}

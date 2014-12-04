using UnityEngine;
using System.Collections;

public class MuscleAnimationController : MonoBehaviour {


	public GameObject[] abductionObj; 
	public GameObject[] adductionObj;
	public GameObject[] anteriorObj;
	public GameObject[] posteriorObj;
	public GameObject[] anteriorlyObj;
	public GameObject[] posteriorlyObj;

	SkinnedMeshRenderer[] abduction; 
	SkinnedMeshRenderer[] adduction;
	SkinnedMeshRenderer[] anterior;
	SkinnedMeshRenderer[] posterior;
	SkinnedMeshRenderer[] anteriorly;
	SkinnedMeshRenderer[] posteriorly;

	public int[] abductionIndex;
	public int[] adductionIndex;
	public int[] anteriorIndex;
	public int[] posteriorIndex;
	public int[] anteriorlyIndex;
	public int[] posteriorlyIndex;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		animate (abduction, abductionIndex, abductionCalc());
		animate (adduction, adductionIndex, adductionCalc());
		animate (anterior, anteriorIndex, anteriorCalc());
		animate (posterior, posteriorIndex, posteriorCalc());
		animate (anteriorly, anteriorlyIndex, anteriorlyCalc());
		animate(posteriorly, posteriorlyIndex, posteriorlyCalc());
	}

	//Array of SkinnedMeshRenderers and indexes to needed blendshapes with the value to set the blendshape too
	void animate(SkinnedMeshRenderer[] obj, int[] index, float value) {
		for(int i=0; i<obj.Length; i++){
			obj[i].SetBlendShapeWeight(index[i], value);
		}
	}

	float abductionCalc() {
		float ret = 0;
		ret = transform.rotation.z;
		return 0;
	}
	float adductionCalc() {
		return 0;
	}
	float anteriorCalc() {
		return 0;
	}
	float posteriorCalc() {
		return 0;
	}
	float anteriorlyCalc() {
		return 0;
	}
	float posteriorlyCalc() {
		return 0;
	}
}

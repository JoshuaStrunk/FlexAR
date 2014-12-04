#pragma strict
var target : GameObject;
var swapValue : Material;

function OnMouseDown () {

	var tempC : Material = target.renderer.material;
		
   target.renderer.material = swapValue;
	swapValue = tempC;
}

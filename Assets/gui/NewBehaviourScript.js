#pragma strict
var target : Material;
var swapValue : Color = Color.white;

function OnMouseDown () {

	var tempC : Color = target.color;
		
   target.color = swapValue;
	swapValue = tempC;
}

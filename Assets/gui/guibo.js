#pragma strict
var shower:GUITexture ;

function Start () {
shower.enabled=false;

}

function OnMouseDown () {
shower.enabled = !shower.enabled ; 

}
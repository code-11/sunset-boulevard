using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using XNode;

public class Location : Node {

    public string locationName;

    [TextArea(15, 20)]
    public string description;

    [Output] public string toFrontDoor;
    [Output] public string toKitchen;
    [Output] public string toBedroom;
    [Output] public string toBathroom;

    // Use this for initialization
    protected override void Init() {
		base.Init();
		
	}

	// Return the correct value of an output port when requested
	public override object GetValue(NodePort port) {
		return null; // Replace this
	}
}
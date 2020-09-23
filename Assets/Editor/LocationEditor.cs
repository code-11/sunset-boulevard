using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNodeEditor;
using XNode;

[CustomNodeEditor(typeof(Location))]
public class LocationEditor : NodeEditor
{
    public override void OnBodyGUI()
    {
        Location node = target as Location;
        NodeEditorGUILayout.PortField(GUIContent.none, target.GetInputPort("input"));
        NodeEditorGUILayout.DynamicPortList("roomLinks", typeof(Location), serializedObject, NodePort.IO.Output, Node.ConnectionType.Override);
        //Called whenever the inspector is drawn for this object.
        if (GUILayout.Button("OH GOD A BUTTON")) { 
             //add everthing the button would do.
        }
    }
}

using UnityEngine;
using UnityEditor;

namespace SceneViewExtension.GUIs {	[CustomEditor (typeof (BeginGroup))]	public class BeginGroupSceneView : Editor {		float _xPos = 5, _yPos = 5;		private void OnSceneGUI () {			Handles.BeginGUI ();			GUI.BeginGroup (new Rect (_xPos, _yPos, 150, 150), "Group", "box");			GUI.Button (new Rect (5, 5, 140, 20), "Button");			GUI.Button (new Rect (5, 30, 140, 20), "Button");			if (GUI.Button (new Rect (5, 55, 140, 20), "Random Position")) {				_xPos = Random.Range (5, 100);				_yPos = Random.Range (5, 100);			}			GUI.EndGroup ();			Handles.EndGUI ();		}	}
}
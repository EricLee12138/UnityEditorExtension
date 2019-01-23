using UnityEngine;
using UnityEditor;
namespace SceneViewExtension.GUILayouts {	[CustomEditor (typeof (BeginArea))]	public class BeginAreaSceneView : Editor {		private void OnSceneGUI () {			Handles.BeginGUI ();

			GUILayout.Button ("Button");
			GUILayout.BeginArea (new Rect (50, 50, 100, 100), new GUIStyle ("box"));			GUILayout.Button ("Button");			GUILayout.EndArea ();

			Handles.EndGUI ();		}	}}
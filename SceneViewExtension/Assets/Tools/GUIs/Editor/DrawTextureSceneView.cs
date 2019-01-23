﻿using UnityEngine;using UnityEditor;namespace SceneViewExtension.GUIs {	[CustomEditor (typeof (DrawTexture))]	public class DrawTextureSceneView : Editor {		DrawTexture _target;		private void OnEnable () {			_target = (DrawTexture)target;		}		private void OnSceneGUI () {			Handles.BeginGUI ();			GUI.DrawTexture (new Rect (5, 5, 100, 100), _target._texture);			GUI.DrawTexture (new Rect (25, 25, 100, 100), Texture2D.whiteTexture, ScaleMode.StretchToFill, true, 0, new Color(0, 0, 0, 0.5f), 0, 5);			Handles.EndGUI ();		}	}}
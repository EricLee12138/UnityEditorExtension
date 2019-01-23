using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModalWindow : MonoBehaviour {	Rect _modalWindow = new Rect (5, 25, 200, 100);	private void OnGUI () {		_modalWindow = GUI.ModalWindow (0, _modalWindow, OnModalWindowGUI, "Modal Window");	}

	private void OnModalWindowGUI (int id) {		if (GUILayout.Button ("Button")) {			GUI.UnfocusWindow ();		}		GUI.DragWindow ();	}
}

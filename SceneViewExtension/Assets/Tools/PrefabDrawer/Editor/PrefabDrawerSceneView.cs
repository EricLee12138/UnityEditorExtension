﻿using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SceneViewExtension.PrefabDrawer {
	public enum Mode {
		Paint,
		Erase

	[CustomEditor (typeof (PrefabDrawer))]

		Mode _mode;
		PrefabDrawer _target;

		List<GameObject> _objs;
		private void OnEnable () {
			_mode = Mode.View;
			_target = (PrefabDrawer)target;
			_objs = new List<GameObject> ();
			foreach (GameObject obj in FindObjectsOfType (typeof (GameObject))) {
				if (obj.GetComponent<PrefabDrawerItem> ())
		}

			Handles.BeginGUI ();

			DrawToolbar ();

			HandleUnityTools ();
			HandleEvents ();

			Handles.EndGUI ();
		}

		private void HandleUnityTools () {
			switch (_mode) {
			case Mode.View:
				Tools.current = Tool.View;
				break;
			case Mode.Paint:
			case Mode.Erase:
				Tools.current = Tool.None;


			switch (_mode) {
				break;
				DrawSelectedPrefab ();
				if (Event.current.type == EventType.MouseDown) {
			case Mode.Erase:
				if (Event.current.type == EventType.MouseDown || Event.current.type == EventType.MouseDrag) {
					Erase (mousePos);
				}
				break;

		private void DrawToolbar () {
			_mode = (Mode)GUI.Toolbar (
				new Rect (5, 5, 300, 40),
				(int)_mode,
				new string [] { "View", "Paint", "Erase" }
			);
		}

		private void DrawSelectedPrefab () {
			Texture2D texture = AssetPreview.GetAssetPreview (_target.SelectedPrefab);
			if (GUI.Button (
				new Rect (310, 5, 40, 40),
				new GUIContent ("", texture)
			)) {
		}

		private void Paint (Vector3 pos) {
			if (_target.SelectedPrefab) {
				GameObject newObj = (GameObject)PrefabUtility.InstantiatePrefab (_target.SelectedPrefab);
				newObj.transform.position = ScreenCoordsToSceneViewCoords (pos);
				newObj.AddComponent<PrefabDrawerItem> ();
				_objs.Add (newObj);
			} else {

		private void Erase (Vector3 pos) {
			Camera camera = SceneView.currentDrawingSceneView.camera;
			Vector3 worldCoord = ScreenCoordsToSceneViewCoords (pos);

			foreach (GameObject obj in _objs) {
					DestroyImmediate (obj);
					break;
		}

		private Vector3 ScreenCoordsToSceneViewCoords (Vector3 screen) {
			Camera camera = SceneView.currentDrawingSceneView.camera;
			Vector3 newPos = camera.ScreenToWorldPoint (new Vector3(screen.x * 2, (camera.pixelHeight / 2 - screen.y) * 2, 0));

			return new Vector3 (newPos.x, newPos.y, 0);
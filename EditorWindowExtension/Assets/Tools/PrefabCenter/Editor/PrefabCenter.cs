﻿using System.Text.RegularExpressions;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace EditorWindowExtension.PrefabCenter {
		List<GameObject> _prefabItems;
		GameObject _shownItem;
		Rect _detailPosition;
		Rect _prevPosition;

		[MenuItem ("Tools/Prefab Center/Open #o")]

		private void Update () {

		private void OnGUI () {
				if (_toolBarIndex == 0 || (int)item.GetComponent<PrefabCenterItem> ().Type == _toolBarIndex) {
			HandleEvent (Event.current);
		}
			_prefabItems.Clear ();
			_prefabItems = GetPrefabsFromAssetDatabase ();

			Repaint ();
		}

		private void OnLostFocus () {
			_showDetail = false;
		}

		private List<GameObject> GetPrefabsFromAssetDatabase () {
				var assetPath = AssetDatabase.GUIDToAssetPath (guid);
				var asset = AssetDatabase.LoadAssetAtPath (assetPath, typeof (GameObject)) as GameObject;
				if (asset.GetComponent<PrefabCenterItem> ()) {
				}

		private void DrawToolBar () {
				new GUIContent("All"),
				new GUIContent("Players"),
				new GUIContent("Enemies"),
				new GUIContent("Collectables"),
				new GUIContent("Blocks")
			};

			if (_toolBarIndex != _prevIndex) {

		private void DrawPrefabItem (GameObject item, Rect pos, GUIStyle style) {
			)) {

		private void DrawDetail () {

		private void OnDetailGUI (int id) {
				Instantiate (_shownItem).name = _shownItem.name;
				ShowNotification (new GUIContent ("Added"));

			if (GUI.Button (new Rect (5, 42, _detailPosition.width - 10, 17), "Show in project")) {
				EditorGUIUtility.PingObject (_shownItem);

			if (GUI.Button (new Rect (5, 64, _detailPosition.width - 10, 17), "Duplicate")) {
			}

			if (GUI.Button (new Rect (5, 86, _detailPosition.width - 10, 17), "Delete")) {
				DeletePrefab ();
			}

				_showDetail = false;

			private void DuplicatePrefab () {

		private void DeletePrefab () {

		private void HandleEvent (Event e) {
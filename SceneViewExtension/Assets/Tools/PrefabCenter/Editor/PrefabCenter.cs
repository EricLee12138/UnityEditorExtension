using System.Text.RegularExpressions;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace SceneViewExtension.PrefabCenter {	public class PrefabCenter : EditorWindow {		
		List<GameObject> _prefabItems;		int _toolBarIndex, _prevIndex;		bool _showDetail, _updateDetail;
		GameObject _shownItem;
		Rect _detailPosition;
		Rect _prevPosition;

		Vector2 _scroll;

		[MenuItem ("Tools/Prefab Center/Open #o")]		public static void OpenPrefabCenter () {			EditorWindow window = GetWindow (typeof (PrefabCenter), false, "Prefab Center");			window.Show ();		}		[MenuItem ("Tools/Prefab Center/Close #c", false)]		static void ClosePrefabCenter () {			EditorWindow window = GetWindow (typeof (PrefabCenter), false, "Prefab Center");			window.Close ();		}		[MenuItem ("Tools/Prefab Center/Close #c", true)]		static bool ClosePrefabCenterValidation () {			return focusedWindow.GetType () == typeof (PrefabCenter);		}		private void Awake () {			_prefabItems = new List<GameObject> ();		}

		private void Update () {			if (System.Math.Abs (_prevPosition.width - position.width) > Mathf.Epsilon) {				SendEvent (EditorGUIUtility.CommandEvent ("Resize"));			}			_prevPosition = new Rect (position);		}		private void OnEnable () {			minSize = new Vector2 (500, 200);			maxSize = new Vector2 (800, maxSize.y);			_prefabItems = GetPrefabsFromAssetDatabase ();		}

		private void OnGUI () {			DrawToolBar ();			var buttonWidth = (position.width - 25 - 15) / 4;			var buttonHeight = buttonWidth + 15;			GUIStyle guiStyle = new GUIStyle (GUI.skin.button);			guiStyle.fontStyle = FontStyle.Bold;			guiStyle.alignment = TextAnchor.MiddleCenter;			guiStyle.imagePosition = ImagePosition.ImageAbove;			int i = 0;
			_scroll = GUI.BeginScrollView (
				new Rect(0, 27, position.width, position.height - 27),
				_scroll,
				new Rect(0, 0, (buttonWidth + 5) * 4 + 5, (buttonHeight + 5) * (_prefabItems.Count / 4 + (_prefabItems.Count % 4 > 0 ? 1 : 0))),
				false, true
			);			foreach (var item in _prefabItems) {
				if (_toolBarIndex == 0 || (int)item.GetComponent<PrefabCenterItem> ().Type == _toolBarIndex) {					var buttonLeft = 5 + (i % 4) * (buttonWidth + 5);					var buttonTop = 0 + (i / 4) * (buttonHeight + 5);					Rect buttonPos = new Rect (buttonLeft, buttonTop, buttonWidth, buttonHeight);					if (buttonPos != _detailPosition || !_showDetail)						DrawPrefabItem (item, buttonPos, guiStyle);					i++;				}			}

			HandleEvent (Event.current);			DrawDetail ();

			GUI.EndScrollView ();
		}		private void OnProjectChange () {
			_prefabItems.Clear ();
			_prefabItems = GetPrefabsFromAssetDatabase ();

			Repaint ();
		}

		private void OnLostFocus () {
			_showDetail = false;
		}

		private List<GameObject> GetPrefabsFromAssetDatabase () {			string [] guids = AssetDatabase.FindAssets ("t:Prefab", new string [] { "Assets/Prefabs" });			List<GameObject> prefabs = new List<GameObject> ();			foreach (string guid in guids) {
				var assetPath = AssetDatabase.GUIDToAssetPath (guid);
				var asset = AssetDatabase.LoadAssetAtPath (assetPath, typeof (GameObject)) as GameObject;
				if (asset.GetComponent<PrefabCenterItem> ()) {					prefabs.Add (asset);
				}			}			return prefabs;		}

		private void DrawToolBar () {			GUIContent [] contents = {
				new GUIContent("All"),
				new GUIContent("Players"),
				new GUIContent("Enemies"),
				new GUIContent("Collectables"),
				new GUIContent("Blocks")
			};			_prevIndex = _toolBarIndex;			_toolBarIndex = GUI.Toolbar (new Rect (5, 5, position.width - 10, 17), _toolBarIndex, contents);

			if (_toolBarIndex != _prevIndex) {				SendEvent (EditorGUIUtility.CommandEvent ("SwitchType"));			}		}

		private void DrawPrefabItem (GameObject item, Rect pos, GUIStyle style) {			Texture2D texture = AssetPreview.GetAssetPreview (item);
			if (GUI.Button (				pos,				new GUIContent (item.name, texture),				style
			)) {				_showDetail = true;				_shownItem = item;				_detailPosition = pos;			}		}

		private void DrawDetail () {
			if (_showDetail) {				BeginWindows ();				GUI.Window (1, _detailPosition, OnDetailGUI, GUIContent.none);				EndWindows ();			}		}

		private void OnDetailGUI (int id) {			if (GUI.Button (new Rect (5, 20, _detailPosition.width - 10, 17), "Add to scene")) {
				Instantiate (_shownItem).name = _shownItem.name;
				ShowNotification (new GUIContent ("Added"));			}

			if (GUI.Button (new Rect (5, 42, _detailPosition.width - 10, 17), "Show in project")) {
				EditorGUIUtility.PingObject (_shownItem);				Selection.activeObject = _shownItem;			}

			if (GUI.Button (new Rect (5, 64, _detailPosition.width - 10, 17), "Duplicate")) {				DuplicatePrefab ();
			}

			if (GUI.Button (new Rect (5, 86, _detailPosition.width - 10, 17), "Delete")) {
				DeletePrefab ();
			}

			if (GUI.Button (new Rect (5, 108, _detailPosition.width - 10, 17), "Select Prefab")) {
				SelectPrefab ();
			}
			if (GUI.Button (new Rect (_detailPosition.width - 16, _detailPosition.height - 16, 12, 12), GUIContent.none, "WinBtnCloseMac")) {
				_showDetail = false;			}			GUI.FocusWindow (1);		}

		private void DuplicatePrefab () {			string newName = _shownItem.name;			int count = 0;			while (AssetDatabase.FindAssets (newName, new string [] { "Assets/Prefabs" }).Length > 0) {				List<string> nameSlots = new List<string> (newName.Split (' '));				string lastSlot = nameSlots [nameSlots.Count - 1];				if (Regex.IsMatch (lastSlot, @"^-?\d+$")) {					nameSlots.RemoveAt (nameSlots.Count - 1);					count = int.Parse (lastSlot) + 1;				} else {					count++;				}				newName = string.Join (" ", nameSlots.ToArray ()) + " " + count.ToString ();			}			PrefabUtility.CreatePrefab (string.Format ("Assets/Prefabs/{0}.prefab", newName), _shownItem);		}

		private void DeletePrefab () {			string path = AssetDatabase.GetAssetPath (_shownItem);			if (EditorUtility.DisplayDialog (				"Delete selected prefab?",				"\t" + path + "\n\nYou cannot undo this action.",				"Delete",				"Cancel"			)) {				AssetDatabase.DeleteAsset (path);				_showDetail = false;			}		}

		private void SelectPrefab () {
			GameObject prefabDrawer = GameObject.Find("Prefab Drawer");
			prefabDrawer.GetComponent<PrefabDrawer.PrefabDrawer> ().SelectedPrefab = _shownItem;		}

		private void HandleEvent (Event e) {			switch (e.commandName) {			case "SwitchType":			case "Resize":			case "Scroll":				_showDetail = false;				break;			}			Repaint ();		}	}}
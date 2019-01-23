using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace EditorWindowExtension.ResponsiveGUIs {
	public enum ResponsiveMode {		RawScript = 0,
		GuiLayout,
		SelectionGrid	}
	public class ResponsiveGUI : EditorWindow {

		static ResponsiveMode _mode;
		int _row = 5, _column = 5;
		[MenuItem ("Tools/ResponsiveGUI/GUI From Raw Scripts")]
		static void OpenFromRawScripts () {
			_mode = ResponsiveMode.RawScript;
			EditorWindow window = GetWindow (typeof (ResponsiveGUI), false, "ResponsiveGUI");
			window.Show ();
		}

		[MenuItem ("Tools/ResponsiveGUI/GUI From GUILayout")]
		static void OpenFromGuiLayout () {
			_mode = ResponsiveMode.GuiLayout;
			EditorWindow window = GetWindow (typeof (ResponsiveGUI), false, "ResponsiveGUI");
			window.Show ();
		}

		[MenuItem ("Tools/ResponsiveGUI/GUI From SelectionGrid")]
		static void OpenFromSelectionGrid () {
			_mode = ResponsiveMode.SelectionGrid;
			EditorWindow window = GetWindow (typeof (ResponsiveGUI), false, "ResponsiveGUI");
			window.Show ();
		}

		private void OnGUI () {
			switch (_mode) {			case ResponsiveMode.RawScript:
				DrawGridWithRawScripts ();
				break;			case ResponsiveMode.GuiLayout:
				DrawGridWithGuiLayout ();
				break;			case ResponsiveMode.SelectionGrid:				DrawGridWithSelectionGrid ();				break;			}		}

		private void DrawGridWithRawScripts () {
			DrawControls ();
			float buttonWidth = (position.width - 5) / _column - 5;
			float buttonHeight = (position.height - 53) / _row - 5;

			for (int i = 0; i < _row; i++) {				float buttonTop = 53 + (i % _row) * (buttonHeight + 5);
				for (int j = 0; j < _column; j++) {					float buttonLeft = 5 + (j % _column) * (buttonWidth + 5);
					GUI.Button (new Rect (buttonLeft, buttonTop, buttonWidth, buttonHeight), string.Format ("Button {0}-{1}", i, j));				}			}		}		private void DrawControls () {
			GUI.BeginGroup (new Rect (5, 5, position.width - 10, 43), GUIContent.none, "box");

			_row = EditorGUI.IntSlider (new Rect (3, 3, position.width - 16, 17), "row", _row, 0, 30);
			_column = EditorGUI.IntSlider (new Rect (3, 23, position.width - 16, 17), "column", _column, 0, 30);

			GUI.EndGroup ();
		}

		private void DrawGridWithGuiLayout () {
			_row = EditorGUILayout.IntSlider ("row", _row, 0, 30);
			_column = EditorGUILayout.IntSlider ("column", _column, 0, 30);
			for (int i = 0; i < _row; i++) {
				GUILayout.BeginHorizontal ();
				for (int j = 0; j < _column; j++) {
					GUILayout.Button (string.Format ("Button {0}-{1}", i, j));
				}
				GUILayout.EndHorizontal ();
			}		}

		private void DrawGridWithSelectionGrid () {			_row = EditorGUILayout.IntSlider ("row", _row, 0, 30);
			_column = EditorGUILayout.IntSlider ("column", _column, 0, 30);

			List<string> contents = new List<string> ();

			for (int i = 0; i < _row; i++) {
				for (int j = 0; j < _column; j++) {
					contents.Add (string.Format ("Button {0}-{1}", i, j));
				}
			}

			GUILayout.SelectionGrid (-1, contents.ToArray (), _column);
		}	}}
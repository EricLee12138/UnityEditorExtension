﻿using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace EditorWindowExtension.ResponsiveGUIs {
	public enum ResponsiveMode {
		GuiLayout,
		SelectionGrid


		static ResponsiveMode _mode;
		int _row = 5, _column = 5;

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
			switch (_mode) {
				DrawGridWithRawScripts ();
				break;
				DrawGridWithGuiLayout ();
				break;

		private void DrawGridWithRawScripts () {
			DrawControls ();

			float buttonHeight = (position.height - 53) / _row - 5;

			for (int i = 0; i < _row; i++) {
				for (int j = 0; j < _column; j++) {
					GUI.Button (new Rect (buttonLeft, buttonTop, buttonWidth, buttonHeight), string.Format ("Button {0}-{1}", i, j));
			GUI.BeginGroup (new Rect (5, 5, position.width - 10, 43), GUIContent.none, "box");

			_row = EditorGUI.IntSlider (new Rect (3, 3, position.width - 16, 17), "row", _row, 0, 30);
			_column = EditorGUI.IntSlider (new Rect (3, 23, position.width - 16, 17), "column", _column, 0, 30);

			GUI.EndGroup ();
		}

		private void DrawGridWithGuiLayout () {
			_row = EditorGUILayout.IntSlider ("row", _row, 0, 30);
			_column = EditorGUILayout.IntSlider ("column", _column, 0, 30);

				GUILayout.BeginHorizontal ();
				for (int j = 0; j < _column; j++) {
					GUILayout.Button (string.Format ("Button {0}-{1}", i, j));
				}
				GUILayout.EndHorizontal ();
			}

		private void DrawGridWithSelectionGrid () {
			_column = EditorGUILayout.IntSlider ("column", _column, 0, 30);

			List<string> contents = new List<string> ();

			for (int i = 0; i < _row; i++) {
				for (int j = 0; j < _column; j++) {
					contents.Add (string.Format ("Button {0}-{1}", i, j));
				}
			}

			GUILayout.SelectionGrid (-1, contents.ToArray (), _column);
		}
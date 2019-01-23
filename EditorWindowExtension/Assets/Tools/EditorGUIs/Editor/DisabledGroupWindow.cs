﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace EditorWindowExtension.EditorGUIs {
		bool _disabled;
		Rect _rect;

		static void Open () {
			EditorWindow window = GetWindow (typeof (DisabledGroupWindow), false, "DisabledGroup");
			window.Show ();
		}
	
		void OnGUI () {
			_disabled = EditorGUI.ToggleLeft (new Rect(5, 5, 200, 17), "Disabled", _disabled);

			EditorGUI.BeginDisabledGroup (_disabled);
			EditorGUI.EndDisabledGroup ();
}
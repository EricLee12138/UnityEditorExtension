﻿using UnityEngine;
using UnityEditor;

namespace EditorWindowExtension.EditorGUIs {
		[MenuItem ("Tools/EditorGUI/PropertyWrapper Window")]
		static void Open () {
			EditorWindow window = GetWindow (typeof (PropertyWrapperWindow), false, "PropertyWrapper");
			window.Show ();
		}

		void OnGUI () {
}
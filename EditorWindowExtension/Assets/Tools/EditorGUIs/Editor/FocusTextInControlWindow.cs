﻿using UnityEngine;
using UnityEditor;

namespace EditorWindowExtension.EditorGUIs {
			if (GUI.Button (new Rect (5, 137, 400, 17), "Remove Focus")) {
				EditorGUI.FocusTextInControl (null);
			}
}
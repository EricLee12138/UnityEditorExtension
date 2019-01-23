using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace EditorWindowExtension.EditorGUIs {	public class DrawWindow : EditorWindow {

		Color _color = Color.white;
		Texture _texture;
		Material _material;
		[MenuItem ("Tools/EditorGUI/Draw")]
		static void Open () {
			EditorWindow window = GetWindow (typeof (DrawWindow), false, "Draw");
			window.Show ();
		}
	
		void OnGUI () {
			EditorGUI.PrefixLabel (new Rect (5, 5, 100, 17), 0, new GUIContent ("Choose a color: "));
			_color = EditorGUI.ColorField (new Rect (200, 5, 200, 17), _color);
			EditorGUI.PrefixLabel (new Rect (5, 27, 100, 17), 1, new GUIContent ("Rect drawn: "));			EditorGUI.DrawRect (new Rect (200, 27, 60, 60), _color);
			EditorGUI.PrefixLabel (new Rect (5, 150, 100, 17), 2, new GUIContent ("Add a texture: "));			_texture = (Texture)EditorGUI.ObjectField (new Rect (200, 150, 60, 60), _texture, typeof(Texture), true);
			EditorGUI.PrefixLabel (new Rect (5, 215, 100, 17), 3, new GUIContent ("Add a material for preview: "));			_material = (Material)EditorGUI.ObjectField (new Rect (200, 215, 200, 17), _material, typeof (Material), true);
			EditorGUI.PrefixLabel (new Rect (5, 237, 100, 17), 3, new GUIContent ("Texture with alpha: "));			if (!_texture) {				EditorGUI.DrawRect (new Rect (200, 237, 60, 60), Color.black);			} else {				EditorGUI.DrawTextureAlpha (new Rect (200, 237, 60, 60), _texture);			}

			EditorGUI.PrefixLabel (new Rect (5, 302, 100, 17), 3, new GUIContent ("Texture preview: "));
			if (!_texture) {
				EditorGUI.DrawRect (new Rect (200, 302, 60, 60), Color.black);
			} else {
				EditorGUI.DrawPreviewTexture (new Rect (200, 302, 60, 60), _texture, _material);
			}		}	}
}
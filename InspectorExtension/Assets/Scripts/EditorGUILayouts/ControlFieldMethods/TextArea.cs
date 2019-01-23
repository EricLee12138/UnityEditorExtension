using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InspectorExtension.EditorGUILayouts {	public class TextArea : MonoBehaviour {		[SerializeField]		string _text = "Hello World.\n" +			"This is a text area.\n" +			"Here you can edit, copy, paste and cut.";		public string Text {			get { return _text; }			set { _text = value; }		}	}}
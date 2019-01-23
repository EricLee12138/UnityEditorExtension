using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InspectorExtension.EditorGUILayouts {	public class Popup : MonoBehaviour {		[SerializeField]		int _popupIndex;		[SerializeField]		int _intPopupIndex;		string [] _options = {		"Cube",
		"Sphere",
		"Plane"	};		int [] _optionValues = { 1, 7, 8 };		public int PopupIndex {			get { return _popupIndex; }			set { _popupIndex = value; }		}		public int IntPopupIndex {			get { return _intPopupIndex; }			set { _intPopupIndex = value; }		}		public string [] Options {			get { return _options; }		}		public int [] OptionValues {			get { return _optionValues; }		}	}}
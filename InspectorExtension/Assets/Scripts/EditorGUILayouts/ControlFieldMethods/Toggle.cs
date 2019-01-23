using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InspectorExtension.EditorGUILayouts {	public class Toggle : MonoBehaviour {		[SerializeField]		bool _toggleRight;		[SerializeField]		bool _toggleLeft;		public bool ToggleRight {			get { return _toggleRight; }			set { _toggleRight = value; }		}		public bool ToggleLeft {			get { return _toggleLeft; }			set { _toggleLeft = value; }		}	}}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InspectorExtension.EditorGUILayouts {	public class Foldout : MonoBehaviour {		[SerializeField]		Vector3 _position;		public Vector3 Position {			get { return _position; }			set { _position = value; }		}	}}
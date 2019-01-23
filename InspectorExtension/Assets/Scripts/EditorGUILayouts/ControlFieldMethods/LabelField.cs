using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InspectorExtension.EditorGUILayouts {	public class LabelField : MonoBehaviour {		[SerializeField]		int _value;		public int Value {			get { return _value; }			set { _value = value; }		}	}}
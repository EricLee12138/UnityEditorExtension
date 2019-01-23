using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InspectorExtension.EditorGUILayouts {	public class DelayedField : MonoBehaviour {		[SerializeField]		double _doubleVal = 10.0;		[SerializeField]		float _floatVal = 10.0f;		[SerializeField]		int _intVal = 10;		[SerializeField]		string _textVal = "10:00";		public double DoubleValue {			get { return _doubleVal; }			set { _doubleVal = value; }		}		public float FloatValue {			get { return _floatVal; }			set { _floatVal = value; }		}		public int IntValue {			get { return _intVal; }			set { _intVal = value; }		}		public string TextValue {			get { return _textVal; }			set { _textVal = value; }		}	}}
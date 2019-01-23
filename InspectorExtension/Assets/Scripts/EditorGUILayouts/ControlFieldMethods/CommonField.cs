using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InspectorExtension.EditorGUILayouts {	public class CommonField : MonoBehaviour {		[SerializeField]		double _doubleVal = 20.0;		[SerializeField]		float _floatVal = 20.0f;		[SerializeField]		int _intVal = 20;		[SerializeField]		string _textVal = "20:00";		public double DoubleValue {			get { return _doubleVal; }			set { _doubleVal = value; }		}		public float FloatValue {			get { return _floatVal; }			set { _floatVal = value; }		}		public int IntValue {			get { return _intVal; }			set { _intVal = value; }		}		public string TextValue {			get { return _textVal; }			set { _textVal = value; }		}	}}
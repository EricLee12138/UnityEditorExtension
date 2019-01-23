using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InspectorExtension.EditorGUILayouts {	public class Slider : MonoBehaviour {		[SerializeField]		float _floatValue = 10.0f;		[SerializeField]		int _intValue = 0;		[SerializeField]		float _minValue = -10.0f;		[SerializeField]		float _maxValue = 10.0f;		public float FloatValue {			get { return _floatValue; }			set { _floatValue = value; }		}		public int IntValue {			get { return _intValue; }			set { _intValue = value; }		}		public float MinValue {			get { return _minValue; }			set { _minValue = value; }		}		public float MaxValue {			get { return _maxValue; }			set { _maxValue = value; }		}	}}
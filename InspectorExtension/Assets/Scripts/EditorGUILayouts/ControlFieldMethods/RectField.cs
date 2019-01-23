using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InspectorExtension.EditorGUILayouts {	public class RectField : MonoBehaviour {		[SerializeField]		Rect _rect;		[SerializeField]		RectInt _rectInt;		public Rect Rect {			get { return _rect; }			set { _rect = value; }		}		public RectInt RectInt {			get { return _rectInt; }			set { _rectInt = value; }		}	}}
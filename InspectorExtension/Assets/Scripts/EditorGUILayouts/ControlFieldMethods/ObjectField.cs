using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InspectorExtension.EditorGUILayouts {	public class ObjectField : MonoBehaviour {		[SerializeField]		Object _obj;		[SerializeField]		Transform _transform;		public Object Obj {			get { return _obj; }			set { _obj = value; }		}		public Transform Transf {			get { return _transform; }			set { _transform = value; }		}	}}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InspectorExtension.EditorGUILayouts {	public class LayerTagField : MonoBehaviour {		[SerializeField]		int _layer;		[SerializeField]		string _tag;		public int Layer {			get { return _layer; }			set { _layer = value; }		}		public string Tag {			get { return _tag; }			set { _tag = value; }		}	}}
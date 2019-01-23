using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InspectorExtension.EditorGUILayouts {	public class EnumPopup : MonoBehaviour {		public enum EnumOptions {			Cube,			Sphere,			Plane		}		[SerializeField]		EnumOptions _option;		public EnumOptions Option {			get { return _option; }			set { _option = value; }		}	}}
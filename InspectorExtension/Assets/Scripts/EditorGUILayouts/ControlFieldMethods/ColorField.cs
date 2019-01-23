using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InspectorExtension.EditorGUILayouts {	public class ColorField : MonoBehaviour {		[SerializeField]		Color _colorFirst;		[SerializeField]		Color _colorSecond;		[SerializeField]		Color _colorThird;		[SerializeField]		Color _colorForth;		public Color ColorFirst {			get { return _colorFirst; }			set { _colorFirst = value; }		}		public Color ColorSecond {			get { return _colorSecond; }			set { _colorSecond = value; }		}		public Color ColorThird {			get { return _colorThird; }			set { _colorThird = value; }		}		public Color ColorForth {			get { return _colorForth; }			set { _colorForth = value; }		}	}}
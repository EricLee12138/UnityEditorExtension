using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InspectorExtension.EditorGUILayouts {	public class BoundsIntField : MonoBehaviour {		[SerializeField]		BoundsInt _boundsIntFirst;		[SerializeField]		BoundsInt _boundsIntSecond;		[SerializeField]		BoundsInt _boundsIntThird;		public BoundsInt BoundsIntFirst {			get { return _boundsIntFirst; }			set { _boundsIntFirst = value; }		}		public BoundsInt BoundsIntSecond {			get { return _boundsIntSecond; }			set { _boundsIntSecond = value; }		}		public BoundsInt BoundsIntThird {			get { return _boundsIntThird; }			set { _boundsIntThird = value; }		}	}}
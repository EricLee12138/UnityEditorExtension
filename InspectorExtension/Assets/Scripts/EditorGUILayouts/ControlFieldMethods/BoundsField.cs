using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InspectorExtension.EditorGUILayouts {	public class BoundsField : MonoBehaviour {		[SerializeField]		Bounds _boundsFirst;		[SerializeField]		Bounds _boundsSecond;		[SerializeField]		Bounds _boundsThird;		public Bounds BoundsFirst {			get { return _boundsFirst; }			set { _boundsFirst = value; }		}		public Bounds BoundsSecond {			get { return _boundsSecond; }			set { _boundsSecond = value; }		}		public Bounds BoundsThird {			get { return _boundsThird; }			set { _boundsThird = value; }		}	}
}
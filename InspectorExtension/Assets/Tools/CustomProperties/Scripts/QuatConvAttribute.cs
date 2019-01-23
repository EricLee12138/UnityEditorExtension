using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InspectorExtension.CustomProperties {	public class QuatConvAttribute : PropertyAttribute {
		bool _rad;

		public bool Rad {			get { return _rad; }		}

		public QuatConvAttribute (bool rad = false) {			_rad = rad;		}	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleGroup : MonoBehaviour {

	[SerializeField]
	bool _ax;
	[SerializeField]
	bool [] _a = { false, false, false };

	[SerializeField]
	bool _bx;
	[SerializeField]
	bool [] _b = { false, false, false };

	public bool Ax {
		get { return _ax; }
		set { _ax = value; }
	}

	public bool Bx {
		get { return _bx; }
		set { _bx = value; }
	}

	public bool [] A {		get { return _a; }
		set { _a = value; }	}

	public bool [] B {
		get { return _b; }
		set { _b = value; }
	}
}

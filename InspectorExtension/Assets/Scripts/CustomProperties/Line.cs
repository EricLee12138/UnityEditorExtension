using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InspectorExtension.CustomProperties;

public class Line : MonoBehaviour {
	[Header("Group One")]
	[Line (true, 1.5f)]
	public int _int_1;
	[Line (150.0f, 1.0f, 0)]
	public float _float_1;

	[Line (150.0f, 1.0f, 0)]
	public double _double_1;

	[Header ("Group Two")]
	[Line (true, 1.5f)]
	public int _int_2;

	[Line (150.0f, 1.0f, 1)]
	public float _float_2;

	[Line (150.0f, 1.0f, 1)]
	public double _double_2;

	[Header ("Group Three")]
	[Line (true, 1.5f)]
	public int _int_3;

	[Line (150.0f, 1.0f, 2)]
	public float _float_3;

	[Line (150.0f, 1.0f, 2)]
	public double _double_3;
}

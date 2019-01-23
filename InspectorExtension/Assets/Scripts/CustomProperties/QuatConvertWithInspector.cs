﻿using UnityEngine;
using InspectorExtension.CustomProperties;

public class QuatConvertWithInspector : MonoBehaviour {
	[QuatConv]
	[SerializeField]
	Vector3 _rotationDeg;
	
	[QuatConv (true)]
	[SerializeField]
	Vector3 _rotationRad;

	public Vector3 RotationDeg {
		set { _rotationDeg = value; }

	public Vector3 RotationRad {
		set { _rotationRad = value; }
}
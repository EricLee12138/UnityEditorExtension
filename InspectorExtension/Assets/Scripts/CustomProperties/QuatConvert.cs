using UnityEngine;
using InspectorExtension.CustomProperties;

public class QuatConvert : MonoBehaviour {
	[QuatConv]
	public Vector3 _rotationDeg;
	
	[QuatConv (true)]
	public Vector3 _rotationRad;

	[QuatConv]
	public Vector2 _no;
}
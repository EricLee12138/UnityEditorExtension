using UnityEngine;

public class DecoratorDrawers : MonoBehaviour {
	[Header ("Int Values")]
	[Space (10)]
	[Tooltip ("This is an int value.")]
	public int _int_1;
	[Space (10)]
	public int _int_2;	[Space (10)]
	public int _int_3;

	[Header ("Float Values")]
	[Range (-5f, 5f)]
	[Space (20)]
	public float [] _floats = new float [3];
}
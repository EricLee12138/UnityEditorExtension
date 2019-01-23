using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawTextureWithTexCoords : MonoBehaviour {
	public Texture _texture;

	[Range (0f, 1f)]
	public float _x;

	[Range (0f, 1f)]
	public float _y;

	[Range (0f, 1f)]	public float _width = 1f;

	[Range (0f, 1f)]
	public float _height = 1f;
}

using UnityEngine;

public class PropertyDrawers : MonoBehaviour {

	[Range (-5, 5)]
	public int _int = -2;

	[Range (-5.0f, 5.0f)]
	public float _float = 3.14f;

	[Multiline ()]
	[ContextMenuItem ("Add Line To All", "AddLine")]
	public string _text = "Line 1\nLine 2";

	[Multiline (2)]
	[ContextMenuItem ("Add Line To All", "AddLine")]
	public string _text_2 = "Line 1\nLine 2";

	[TextArea ()]
	[ContextMenuItem ("Add Line To All", "AddLine")]
	public string _textArea = "Line 1\nLine 2\nLine 3\nLine 4\nLine 5\nLine 6\nLine 7";

	[TextArea (4, 6)]	[ContextMenuItem ("Add Line To All", "AddLine")]
	public string _textArea_4_6 = "Line 1\nLine 2\nLine 3\nLine 4\nLine 5\nLine 6\nLine 7";

	[ContextMenu("Reset All Value")]
	public void ResetAll () {		_int = -2;
 		_float = 3.14f;
 		_text = "Line 1\nLine 2";
 		_text_2 = "Line 1\nLine 2";
 		_textArea = "Line 1\nLine 2\nLine 3\nLine 4\nLine 5\nLine 6\nLine 7";
 		_textArea_4_6 = "Line 1\nLine 2\nLine 3\nLine 4\nLine 5\nLine 6\nLine 7";	}

	public void AddLine() {		_text += "\nNew Line";
		_text_2 += "\nNew Line";
		_textArea += "\nNew Line";
		_textArea_4_6 += "\nNew Line";	}
}

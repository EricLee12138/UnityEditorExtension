using UnityEditor;

namespace InspectorExtension.EditorGUILayouts {
	[CustomEditor (typeof (Slider))]
	public class SliderInspector : Editor {		Slider _target;

		float _minValue;		float _maxValue;

		void OnEnable () {
			_target = (Slider)target;
			_minValue = _target.MinValue;
			_maxValue = _target.MaxValue;
		}

		public override void OnInspectorGUI () {
			_target.FloatValue = EditorGUILayout.Slider ("Float Slider", _target.FloatValue, 5.0f, 25.0f);
			_target.IntValue = EditorGUILayout.IntSlider ("Int Slider", _target.IntValue, -10, 10);
			EditorGUILayout.MinMaxSlider ("Min Max Slider", ref _minValue, ref _maxValue, -25.0f, 25.0f);
		}
	}
}
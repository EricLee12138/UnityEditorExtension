using UnityEngine;
using UnityEditor;

namespace InspectorExtension.DefauleComponents {
	[CustomEditor (typeof (Camera))]
	public class CameraExtensionInspector : Editor {
		Camera _target;

		private void OnEnable () {
			_target = (Camera)target;
		}

		public override void OnInspectorGUI () {
			base.OnInspectorGUI ();

			if (GUILayout.Button ("Set Camera Randomly")) {
				Vector3 randomPosition = GenerateRandomPosition (10, 10, 10);
				SetCameraPosition (_target, randomPosition);
			}
		}

		Vector3 GenerateRandomPosition (float boundX, float boundY, float boundZ) {
			return new Vector3 (
				Random.Range (-boundX, boundX),
				Random.Range (-boundY, boundY),
				Random.Range (-boundZ, boundZ)
			);
		}

		void SetCameraPosition (Camera camera, Vector3 position) {
			camera.transform.position = position;
		}
	}
}
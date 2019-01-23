using UnityEngine;

namespace SceneViewExtension.PrefabDrawer {	public class PrefabDrawer : MonoBehaviour {
		[SerializeField]
		GameObject _selectedPrefab;

		public GameObject SelectedPrefab {			get { return _selectedPrefab; }
			set { _selectedPrefab = value; }		}
	}}
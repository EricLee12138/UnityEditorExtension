﻿using UnityEngine;

namespace SceneViewExtension.PrefabDrawer {
		[SerializeField]
		GameObject _selectedPrefab;

		public GameObject SelectedPrefab {
			set { _selectedPrefab = value; }
	}
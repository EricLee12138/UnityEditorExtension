using UnityEngine;

namespace EditorWindowExtension.PrefabCenter {	public enum PrefabCategory {		None = 0,		Players,		Enemies,		Collectables,		Blocks	};	public class PrefabCenterItem : MonoBehaviour {		[SerializeField]		PrefabCategory _prefabType = PrefabCategory.None;		public PrefabCategory Type {			get { return _prefabType; }		}	}
}
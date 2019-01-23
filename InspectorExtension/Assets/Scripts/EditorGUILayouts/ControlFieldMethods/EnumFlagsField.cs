using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InspectorExtension.EditorGUILayouts {	public class EnumFlagsField : MonoBehaviour {		public enum EnumFlags : int {			A = 1 << 0,			B = 1 << 1,			C = 1 << 2		}		public enum CustomEnumFlags : int {			None = 0,			CustomA = 1 << 0,			CustomB = 1 << 1,			CustomC = 1 << 2,			All = ~0		}		[SerializeField]		EnumFlags _flags;		[SerializeField]		CustomEnumFlags _customFlags;		public EnumFlags Flags {			get { return _flags; }			set { _flags = value; }		}		public CustomEnumFlags CustomFlags {			get { return _customFlags; }			set { _customFlags = value; }		}	}}
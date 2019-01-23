using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InspectorExtension.EditorGUILayouts {	public class PasswordField : MonoBehaviour {		[SerializeField]		string _password = "password";		public string Password {			get { return _password; }			set { _password = value; }		}	}}
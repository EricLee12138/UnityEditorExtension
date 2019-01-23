﻿using UnityEngine;
using UnityEditor;

namespace InspectorExtension.CustomProperties {
	[CustomPropertyDrawer (typeof (QuatConvAttribute))]

		public override float GetPropertyHeight (SerializedProperty property, GUIContent label) {

					new Rect (position.x, position.y, position.width, position.height / 2),
					label,
					property.vector3Value
				);

				Quaternion quaternion = ConvertQuaternion (property.vector3Value, (attribute as QuatConvAttribute).Rad);
				EditorGUI.SelectableLabel (
					new Rect (position.x, position.y + position.height / 2, position.width, position.height / 2),
					string.Format(
						"Quaternion Converted: (x: {0}, y: {1}, z: {2}, w: {3})",
						quaternion.x,
						quaternion.y,
						quaternion.z,
						quaternion.w
					),
					"label"
				);
					position,
					"Cannot use attribute [QuatConv] on type " + property.propertyType.ToString () + ".",
					MessageType.Error
				);
			}

		Quaternion ConvertQuaternion (Vector3 rotation, bool useRad) {
			if (!useRad) {
					Mathf.Rad2Deg * rotation.x,
					Mathf.Rad2Deg * rotation.y,
					Mathf.Rad2Deg * rotation.z
				);

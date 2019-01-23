using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEditor;

namespace InspectorExtension.CustomProperties {
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]	public class LineAttribute : PropertyAttribute {		bool _expanded = true;

		float _width = 100.0f;
		float _height = 2.0f;
		int _alignment = 0;

		public bool Expanded {
			get { return _expanded; }
		}

		public float Width {
			get { return _width; }		}

		public float Height {
			get { return _height; }
		}

		public int Alignment {
			get { return _alignment; }
		}

		public LineAttribute (bool expanded = true, float height = 1.0f) {			_expanded = expanded;

			_height = height;
		}

		public LineAttribute (float width, float height = 1.0f, int alignment = 0) {
			_expanded = false;

			_width = width;
			_height = height;
			_alignment = alignment;
		}	}}
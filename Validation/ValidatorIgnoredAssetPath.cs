using System;
using UnityEngine;

namespace DTValidator {
	[CreateAssetMenu(fileName = "ValidatorIgnoredAssetPath", menuName = "DTValidator/ValidatorIgnoredAssetPath")]
	public class ValidatorIgnoredAssetPath : ScriptableObject {
		public bool Enabled = true;
		public string Path;
	}
}

#if UNITY_EDITOR
using System;
using System.Collections.Generic;
using System.Linq;

namespace DTValidator.Internal {
	public static class ValidatorIgnoredAssetPathProvider {
		public static IList<ValidatorIgnoredAssetPath> GetIgnoredAssetPaths() {
			if (currentProvider_ == null) {
				return AssetDatabaseUtil.AllAssetsOfType<ValidatorIgnoredAssetPath>()
					.Where(config => config.Enabled).ToList();
			}

			return currentProvider_.Invoke();
		}

		public static void SetCurrentProvider(Func<IList<ValidatorIgnoredAssetPath>> provider) {
			currentProvider_ = provider;
		}

		public static void ClearCurrentProvider() {
			currentProvider_ = null;
		}


		// PRAGMA MARK - Internal
		private static Func<IList<ValidatorIgnoredAssetPath>> currentProvider_;
	}
}
#endif

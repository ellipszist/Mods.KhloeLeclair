using System;
using System.Collections.Generic;

using StardewValley;

namespace Leclair.Stardew.Almanac.Models {
	public struct SubLocation {

		public string Key { get; }
		public int Area { get; }

		public SubLocation(string key, int area) {
			Key = key;
			Area = area;
		}

		public GameLocation Location {
			get {
				foreach (var loc in Game1.locations)
					if (loc.Name == Key)
						return loc;

				return null;
			}
		}

		public override bool Equals(object obj) {
			return obj is SubLocation location &&
				   Key == location.Key &&
				   Area == location.Area;
		}

		public override int GetHashCode() {
			return HashCode.Combine(Key, Area);
		}

		public static bool operator ==(SubLocation left, SubLocation right) {
			return left.Equals(right);
		}

		public static bool operator !=(SubLocation left, SubLocation right) {
			return !(left == right);
		}
	}
}

using System;
using Newtonsoft.Json;

using Microsoft.Xna.Framework;

using Leclair.Stardew.Common.Serialization.Converters;
using Leclair.Stardew.Common.UI;
using Leclair.Stardew.Common.Types;

namespace Leclair.Stardew.Almanac.Models {
	public class Theme : BaseThemeData {

		[JsonConverter(typeof(ColorConverter))]
		public Color? CoverTextColor { get; set; }

		[JsonConverter(typeof(ColorConverter))]
		public Color? CoverYearColor { get; set; }

		public CaseInsensitiveDictionary<PageOffset> PageOffsets { get; set; }

		public Style Standard { get; set; } = new Style {
			CustomScroll = false
		};

		public Style Magic { get; set; } = new Style {
			CustomScroll = true
		};

	}

	public class PageOffset {
		public int X { get; set; }
		public int Y { get; set; }
	}

	public class Style {

		public bool CustomScroll { get; set; }

		public int ScrollOffsetTop { get; set; } = -9999;
		public int ScrollOffsetBottom { get; set; } = -9999;


		[JsonConverter(typeof(ColorConverter))]
		public Color? SeasonTextColor { get; set; }

		[JsonConverter(typeof(ColorConverter))]
		public Color? CalendarLabelColor { get; set; }

		[JsonConverter(typeof(ColorConverter))]
		public Color? CalendarDayColor { get; set; }

		[JsonConverter(typeof(ColorConverter))]
		public Color? CalendarDimColor { get; set; }
		public float? CalendarDimOpacity { get; set; }

		[JsonConverter(typeof(ColorConverter))]
		public Color? CalendarHighlightColor { get; set; }

		[JsonConverter(typeof(ColorConverter))]
		public Color? TextColor { get; set; }

		[JsonConverter(typeof(ColorConverter))]
		public Color? TextShadowColor { get; set; }

	}
}

﻿/*
 * Copyright 2010, 2011, 2012, 2013 mapsforge.org
 * Copyright 2016 Dirk Weltz
 *
 * This program is free software: you can redistribute it and/or modify it under the
 * terms of the GNU Lesser General Public License as published by the Free Software
 * Foundation, either version 3 of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful, but WITHOUT ANY
 * WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A
 * PARTICULAR PURPOSE. See the GNU Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License along with
 * this program. If not, see <http://www.gnu.org/licenses/>.
 */

namespace org.mapsforge.map.scalebar
{
	public sealed class ImperialUnitAdapter : DistanceUnitAdapter
	{
		public static readonly ImperialUnitAdapter INSTANCE = new ImperialUnitAdapter();
		private const double METER_FOOT_RATIO = 0.3048;
		private const int ONE_MILE = 5280;
		private static readonly int[] SCALE_BAR_VALUES = new int[] {26400000, 10560000, 5280000, 2640000, 1056000, 528000, 264000, 105600, 52800, 26400, 10560, 5280, 2000, 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1};

		private ImperialUnitAdapter()
		{
			// do nothing
		}

		public double MeterRatio
		{
			get
			{
				return METER_FOOT_RATIO;
			}
		}

		public int[] ScaleBarValues
		{
			get
			{
				return SCALE_BAR_VALUES;
			}
		}

		public string GetScaleText(int mapScaleValue)
		{
			if (mapScaleValue < ONE_MILE)
			{
				return mapScaleValue + " ft";
			}
			return (mapScaleValue / ONE_MILE) + " mi";
		}
	}
}
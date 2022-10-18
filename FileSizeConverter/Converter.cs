using System;

namespace FileSizeConverter
{
    /// <summary>Convert a FileSize from Bytes to any wanted Size Unit</summary>
    public static class Converter
    {
        /// <summary>Size Specifications for Converting from Bytes</summary>
        public enum SizeUnits
        {
            Byte, KB, MB, GB, TB, PB, EB, ZB, YB
        }

        public enum DisplayUnitState
        {
            /// <summary>The SizeUntit will be displayed (ex.: 265 GB)</summary>
            Shown,
            /// <summary>The SizeUnit will not be displayed (ex.: 265)</summary>
            Hidden
        }

        /// <summary>Convert Bytes To Wanted Size Unit</summary>
        /// <param name="unit">Unit (GB, MB, ...)</param>
        /// <param name="state">State for Unit Letters</param>
        public static string ToSize(this Int64 value, SizeUnits unit, DisplayUnitState state)
        {
            if (state == DisplayUnitState.Shown)
                return (value / (double)Math.Pow(1024, (Int64)unit)).ToString("0.00" + unit);
            else if (state == DisplayUnitState.Hidden)
                return (value / (double)Math.Pow(1024, (Int64)unit)).ToString("0.00");
            else
                throw new Exception("Not a valid DisplayUnitState");
        }
    }
}

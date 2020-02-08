using System;
using System.Collections.Generic;
using System.Text;

namespace jafleet.Commons
{
    public static class SeatConfigUtil
    {
        public static string GenerateSeatConfigString(int? F,int? C,int? PY,int? P,int? J,int? Y,int? sum)
        {
            var seatConfig = new StringBuilder();
            bool notFirst = false;
            if (F.HasValue)
            {
                seatConfig.Append("F");
                seatConfig.Append(F.Value);
                notFirst = true;
            }
            if (C.HasValue)
            {
                seatConfig.Append(notFirst ? "," : string.Empty);
                seatConfig.Append("C");
                seatConfig.Append(C.Value);
                notFirst = true;
            }
            if (PY.HasValue)
            {
                seatConfig.Append(notFirst ? "," : string.Empty);
                seatConfig.Append("PY");
                seatConfig.Append(PY.Value);
                notFirst = true;
            }
            if (P.HasValue)
            {
                seatConfig.Append(notFirst ? "," : string.Empty);
                seatConfig.Append("P");
                seatConfig.Append(P.Value);
                notFirst = true;
            }
            if (J.HasValue)
            {
                seatConfig.Append(notFirst ? "," : string.Empty);
                seatConfig.Append("J");
                seatConfig.Append(J.Value);
                notFirst = true;
            }
            if (Y.HasValue)
            {
                seatConfig.Append(notFirst ? "," : string.Empty);
                seatConfig.Append("Y");
                seatConfig.Append(Y.Value);
            }

            seatConfig.Append($" ({sum.ToString()})");

            return seatConfig.ToString();
        }
        public static string GenerateSeatConfigLongString(int? F, int? C, int? PY, int? P, int? J, int? Y, int? sum, string airline, string type)
        {
            return GenerateSeatConfigString(F, C, PY, P, J, Y,sum) + $" ({airline}-{type})";
        }
    }

}

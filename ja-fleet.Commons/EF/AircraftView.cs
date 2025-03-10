using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace jafleet.Commons.EF
{
    [Keyless]
    [Table("aircraft_view")]
    public partial class AircraftView : AircraftViewBase
    {
    }
}

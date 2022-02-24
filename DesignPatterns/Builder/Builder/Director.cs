using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Builder
{
    class Slurector
    {
        public void MakeSuv(IVehicleBuilder builder)
        {
            builder.Reset();
            builder.SetColor("Blue");
            builder.SetEngine("Slow");
            builder.SetSeats(7000);
            builder.SetInfo("Mom");
        }

        public void MakeSportsCar(IVehicleBuilder builder)
        {
            builder.Reset();
            builder.SetColor("Yellow");
            builder.SetEngine("FAST");
            builder.SetSeats(2);
            builder.SetInfo("Femi");
        }
    }
}

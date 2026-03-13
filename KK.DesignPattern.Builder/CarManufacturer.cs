using KK.DesignPattern.Builder.Builders;
using KK.DesignPattern.Builder.Exceptions;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace KK.DesignPattern.Builder
{
    internal class CarManufacturer
    {
        private ICarBuilder? _carBuilder;

        public void SetBuilder(ICarBuilder builder)
        {
            this._carBuilder = builder;
        }

        public Car Construct()
        {
            if (_carBuilder != null)
            {
                return this._carBuilder
                    .SetEngine("ENGINE")
                    .SetSeats("SEATS")
                    .SetGps("GPS")
                    .SetSunroof("SUNROOF")
                    .Build();
            }

            throw new CarBuilderNotSetException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using KK.DesignPattern.Builder.Builders;

namespace KK.DesignPattern.Builder
{
    internal class CarDealer
    {
        private CarManufacturer manufacturer = new CarManufacturer();

        private CarBuilderSport sportCarBuilder = new CarBuilderSport();

        private CarBuilderElectric electricCarBuilder = new CarBuilderElectric();

        public Car OrderSportCar()
        {
            this.manufacturer.SetBuilder(sportCarBuilder);
            return this.manufacturer.Construct();
        }

        public Car OrderElectricCar()
        {
            this.manufacturer.SetBuilder(electricCarBuilder);
            return this.manufacturer.Construct();
        }
    }
}

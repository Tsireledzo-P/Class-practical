namespace moto;
using System;

public class Car :: Vehicle
{
   //declare variables 
    public int numSeats { get;set;}

//constructor
  public Car(string name, string model, int year, double rentalPrice, int numSeats)
{
    super(make, model, year, rentalPrice);
    this.numSeats = numSeats;
}
//override
@Override
public double CalculateRentalCost(int days)
{
    return super.CalculateRentalCost(days);
}


}

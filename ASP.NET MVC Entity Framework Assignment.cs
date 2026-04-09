decimal total = 50;

// Age logic
int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
if (age <= 18) total += 100;
else if (age <= 25) total += 50;
else total += 25;

// Car year
if (insuree.CarYear < 2000) total += 25;
if (insuree.CarYear > 2015) total += 25;

// Porsche logic
if (insuree.CarMake == "Porsche")
{
    total += 25;
    if (insuree.CarModel == "911 Carrera") total += 25;
}

// Tickets
total += insuree.SpeedingTickets * 10;

// DUI
if (insuree.HasDUI) total += total * 0.25m;

// Coverage
if (insuree.IsFullCoverage) total += total * 0.5m;

insuree.Quote = total;
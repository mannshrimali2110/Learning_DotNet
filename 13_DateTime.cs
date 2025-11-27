using System;

Console.WriteLine("DateTime Operations");
DateTime now = DateTime.Now;
Console.WriteLine("Current Date & Time: " + now);

DateTime tomorrow = now.AddDays(1);
Console.WriteLine("Tomorrow: " + tomorrow);

DateTime nextWeek = now.AddDays(7);
Console.WriteLine("Next Week: " + nextWeek);

DateTime birthday = new DateTime(2000, 5, 15);
Console.WriteLine("Birthday: " + birthday);
Console.WriteLine("Day of Week: " + birthday.DayOfWeek);

TimeSpan ageSpan = now - birthday;
Console.WriteLine("Age in Days: " + ageSpan.Days);
Console.WriteLine("Age in Years: " + (ageSpan.Days / 365));

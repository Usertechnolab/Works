using System.Runtime.Serialization;

int currentHours = 23;
int currentMinutes = 59;
int minutesToAdd = 2;
DateTime currentTime = new DateTime(1, 1, 1, currentHours, currentMinutes, 0);
DateTime newTime = currentTime.AddMinutes(minutesToAdd);
Console.WriteLine(newTime.ToString("HH:mm"));
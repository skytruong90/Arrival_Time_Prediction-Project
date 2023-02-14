# Title: Arrival Time Prediction
### This program is coded in C#

## Purpose:
I was waiting for my wife to get done with her makeup for an event one day and I was wondering if I could create a program that would predict what time she will be done.

## The algorithm:
This program first gets the current time using DateTime.Now. It then asks the user to input the expected travel time, distance from the destination, and traffic condition using Console.ReadLine and int.Parse. The expected arrival time is then calculated by adding the expected travel time to the current time using AddMinutes.

The program then calculates the additional travel time based on the traffic condition using a switch statement. The additional travel time is added to the expected arrival time using AddMinutes and the final expected arrival time is printed to the console using ToString("hh:mm tt").

Note that this is a very basic program and does not take into account many other factors that could affect arrival time such as weather conditions, road closures, and accidents. It is also important to note that this program is purely for educational purposes and should not be used in real-life scenarios where accurate arrival time prediction is critical.

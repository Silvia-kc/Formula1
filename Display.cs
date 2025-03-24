using Formula1.Controllers;
using Formula1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1.View
{
    public class Display
    {
        DriverController driverController=new DriverController();
        TeamController teamController=new TeamController();
        public async Task ShowMenu()
        {
            Console.WriteLine("Welcome to Formula1!");
            while (true)
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("1.Get all teams");
                Console.WriteLine("2.Get team by id");
                Console.WriteLine("3.Get teams by country");
                Console.WriteLine("4.Get oldest team");
                Console.WriteLine("5.Get all drivers");
                Console.WriteLine("6.Get driver by id");
                Console.WriteLine("7.Get driver by last name");
                Console.WriteLine("8.Get drivers by nationality");
                Console.WriteLine("9.End");
                int num=int.Parse(Console.ReadLine());
                if(num==9)
                {
                    break;
                }
                switch (num)
                {
                    case 1:
                        List<Team> teams=await teamController.GetAllTeams();
                        foreach (var team in teams)
                        {
                            Console.WriteLine(team.TeamName);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter team id: ");
                        int teamId=int.Parse(Console.ReadLine());
                        Team teams2=await teamController.GetTeamById(teamId);
                        Console.WriteLine($"Team {teams2.TeamName} from {teams2.Country}. Foundation in {teams2.FoundationYear}");
                        break;
                    case 3:
                        Console.WriteLine("Enter team country: ");
                        string country=Console.ReadLine();
                        List<Team> teams3=await teamController.GetTeamsByCountry(country);
                        foreach (var team in teams3)
                        {
                            Console.WriteLine(team.TeamName);
                        }
                        break;
                    case 4:
                        Team teams4=await teamController.GetOldestTeam();
                        Console.WriteLine(teams4.TeamName);
                        break;
                    case 5:
                        List<Driver> drivers=await driverController.GetAllDrivers();
                        foreach (var driver in drivers)
                        {
                            Console.WriteLine($"{driver.FirstName} {driver.LastName}");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Enter driver id: ");
                        int driverId=int.Parse(Console.ReadLine());
                        Driver driver2=await driverController.GetDriverById(driverId);
                        Console.WriteLine($"Driver {driver2.FirstName} {driver2.LastName} born in {driver2.BirthDate}. Nationality: {driver2.Nationality}");
                        break;
                    case 7:
                        Console.WriteLine("Enter driver last name: ");
                        string lastName=Console.ReadLine();
                        Driver driver3=await driverController.GetDriverByLastName(lastName);
                        Console.WriteLine($"{driver3.FirstName} {driver3.LastName}");
                        break;
                    case 8:
                        Console.WriteLine("Enter nationalirty: ");
                        string nationality=Console.ReadLine();
                        List<Driver> drivers4=await driverController.GetDriversByNationality(nationality);
                        foreach (var driver in drivers4)
                        {
                            Console.WriteLine($"{driver.FirstName} {driver.LastName}");
                        }
                        break;
                    default:
                        Console.WriteLine("This option does not exist!");
                    break;
                }

            }

        }
    }
}

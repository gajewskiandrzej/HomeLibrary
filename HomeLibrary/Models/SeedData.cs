using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace HomeLibrary.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Elements.Any())
            {
                context.Elements.AddRange(
                    new Element
                    {
                        Carries = "Książka",
                        Title = "ASP.NET Core MVC 2",
                        Year = "2017-05-15",
                        NameOfAuthors = "Adam Freeman",
                        Cover = "twarda",
                        Description = "Zaawansowane programowanie",
                        Status = "Na półce"
                    },
                    new Element
                    {
                        Carries = "Książka",
                        Title = "C# 6.0",
                        Year = "2016-08-13",
                        NameOfAuthors = "Mark Michaelis, Eric Lippert",
                        Cover = "twarda",
                        Description = "Kompletny przewodnik dla praktyków",
                        Status = "Na półce"
                    },
                    new Element
                    {
                        Carries = "Książka",
                        Title = "Visual Studio 2017",
                        Year = "2017-05-15",
                        NameOfAuthors = "Jacek Matulewski",
                        Cover = "miękka",
                        Description = "Tworzenie aplikacji Windows w języku C#",
                        Status = "Wypożyczona"
                    },
                    new Element
                    {
                        Carries = "Książka",
                        Title = "Tworzenie nowoczesnych aplikacji graficznych w WPF",
                        Year = "2012-03-18",
                        NameOfAuthors = "Jarosław Cisek",
                        Cover = "miękka",
                        Description = "Dobry interfejs graficzny aplikacji Windows? Tylko WPF!",
                        Status = "Wypożyczona"
                    },
                    new Element
                    {
                        Carries = "Książka",
                        Title = "Rusz głową! C#",
                        Year = "2014-10-30",
                        NameOfAuthors = "Jennifer Greene, Andrew Stellman",
                        Cover = "miękka",
                        Description = "Doskonały podręcznik do nauki praktycznego programowania w C#, XAML i .NET",
                        Status = "Na półce"
                    },
                    new Element
                    {
                        Carries = "Książka",
                        Title = "ASP.NET 4 z wykorzystaniem C# i VB",
                        Year = "2010-11-18",
                        NameOfAuthors = "Bill Evjen, Scott Hanselman, Devin Rader",
                        Cover = "twarda",
                        Description = "Zaawansowane programowanie",
                        Status = "Na półce"
                    },
                    new Element
                    {
                        Carries = "DVD",
                        Title = "Wędrówki z bestiami",
                        Year = "2007-03-08",
                        NameOfAuthors = "Tim Haines",
                        Cover = "kolor",
                        Description = "65 milionów lat temu panowanie dinozaurów na Ziemi dobiegło końca. Kataklizm wywołany przez wielką asteroidę...",
                        Status = "Wypozyczona"
                    },
                    new Element
                    {
                        Carries = "DVD",
                        Title = "Gwiezdne wrota",
                        Year = "2005-04-18",
                        NameOfAuthors = "Roland Emmerich",
                        Cover = "kolor",
                        Description = "Pełna reżyserska wersja jednego z najsłynniejszych filmów science-fiction",
                        Status = "Na półce"
                    },
                    new Element
                    {
                        Carries = "DVD",
                        Title = "Gra",
                        Year = "1997-04-08",
                        NameOfAuthors = "David Fincher",
                        Cover = "kolor",
                        Description = "Nicholas Van Orton kończy 48 lat. Rocznica jak rocznica, Van Orton nie przejmowałby się nią, gdyby nie...",
                        Status = "Na półce"
                    },
                    new Element
                    {
                        Carries = "CD",
                        Title = "Hardwired... To Self Destruct",
                        Year = "2016-11-18",
                        NameOfAuthors = "Metallica",
                        Cover = "kolor",
                        Description = "Metallica – amerykański zespół heavymetalowy założony w Los Angeles w 1981 roku przez Jamesa Hetfielda i Larsa Ulricha. Uważany za jeden z najważniejszych i najbardziej wpływowych zespołów metalowych lat 80.",
                        Status = "Na półce"
                    },
                    new Element
                    {
                        Carries = "CD",
                        Title = "Keeper of the Seven Keys Part I",
                        Year = "2008-07-04",
                        NameOfAuthors = "Helloween",
                        Cover = "kolor",
                        Description = "Jest to jeden z najbardziej znaczących albumów w dziejach metalu – płyta ta ukształtowała europejski power metal na następne lata",
                        Status = "Wypożyczona"
                    });
                context.SaveChanges();
            }
        }
    }
}

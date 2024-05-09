using System;
using ConcertLibrary;
using Newtonsoft.Json;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Генерація випадкового масиву екземплярів класу
            Concert[] concerts = GenerateConcertsArray(5);

            // Серіалізація масиву у JSON файл
            string jsonFilePath = "concerts.json";
            SerializeConcertsToJson(concerts, jsonFilePath);
            Console.WriteLine("Масив концертів був серіалізований у JSON файл.");

            // Десеріалізація масиву з файлу та виведення на екран
            Concert[] deserializedConcerts = DeserializeConcertsFromJson(jsonFilePath);
            Console.WriteLine("Масив концертів, десеріалізований з JSON файлу:");
            foreach (Concert concert in deserializedConcerts)
            {
                Console.WriteLine(concert.ToString());
            }

            Console.ReadLine();
        }

        static Concert[] GenerateConcertsArray(int length)
        {
            Random random = new Random();
            Concert[] concerts = new Concert[length];

            string[] types = Enum.GetNames(typeof(Genre));
            string[] firstNames = { "John", "Emma", "Michael", "Olivia", "William" };
            string[] lastNames = { "Smith", "Johnson", "Brown", "Davis", "Miller" };
            string[] organizers = { "Concert Company 1", "Concert Company 2", "Concert Company 3" };

            for (int i = 0; i < length; i++)
            {
                string organizer = organizers[random.Next(organizers.Length)];
                DateTime date = DateTime.Now.AddDays(i);
                Concert concert = new Concert(organizer, date);

                int performanceCount = random.Next(1, 5);
                for (int j = 0; j < performanceCount; j++)
                {
                    string firstName = firstNames[random.Next(firstNames.Length)];
                    string lastName = lastNames[random.Next(lastNames.Length)];
                    Performer performer = new Performer(firstName, lastName);

                    string title = types[random.Next(types.Length)];
                    int duration = random.Next(30, 120);
                    Performance performance = new Performance(performer, title, duration);

                    concert.AddPerformance(performance);
                }

                concerts[i] = concert;
            }

            return concerts;
        }

        static void SerializeConcertsToJson(Concert[] concerts, string filePath)
        {
            ConcertDTO[] concertDTOs = new ConcertDTO[concerts.Length];

            for (int i = 0; i < concerts.Length; i++)
            {
                concertDTOs[i] = ConvertToDTO(concerts[i]);
            }

            string json = JsonConvert.SerializeObject(concertDTOs, Formatting.Indented);
            System.IO.File.WriteAllText(filePath, json);
        }

        static Concert[] DeserializeConcertsFromJson(string filePath)
        {
            string json = System.IO.File.ReadAllText(filePath);
            ConcertDTO[] concertDTOs = JsonConvert.DeserializeObject<ConcertDTO[]>(json);

            Concert[] concerts = new Concert[concertDTOs.Length];

            for (int i = 0; i < concertDTOs.Length; i++)
            {
                concerts[i] = ConvertFromDTO(concertDTOs[i]);
            }

            return concerts;
        }

        static ConcertDTO ConvertToDTO(Concert concert)
        {
            ConcertDTO concertDTO = new ConcertDTO
            {
                Organizer = concert.Organizer,
                Date = concert.Date,
                Performances = new System.Collections.Generic.List<PerformanceDTO>()
            };

            foreach (Performance performance in concert.Performances)
            {
                PerformanceDTO performanceDTO = new PerformanceDTO
                {
                    Performer = new PerformerDTO
                    {
                        FirstName = performance.Performer.FirstName,
                        LastName = performance.Performer.LastName
                    },
                    Title = performance.Title,
                    Duration = performance.Duration
                };

                concertDTO.Performances.Add(performanceDTO);
            }

            return concertDTO;
        }

        static Concert ConvertFromDTO(ConcertDTO concertDTO)
        {
            Concert concert = new Concert(concertDTO.Organizer, concertDTO.Date);

            foreach (PerformanceDTO performanceDTO in concertDTO.Performances)
            {
                Performer performer = new Performer(performanceDTO.Performer.FirstName, performanceDTO.Performer.LastName);
                Performance performance = new Performance(performer, performanceDTO.Title, performanceDTO.Duration);

                concert.AddPerformance(performance);
            }

            return concert;
        }
    }
}
using System;
using System.Collections.Generic;

namespace ConcertLibrary
{
    public enum Genre
    {
        Instrumental,
        Vocal,
        Poem,
        Prose
    }

    public class Performer : ICloneable, IComparable<Performer>
    {
        private string firstName;
        private string lastName;

        public Performer(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public object Clone()
        {
            return new Performer(firstName, lastName);
        }

        public int CompareTo(Performer other)
        {
            return string.Compare(lastName, other.lastName, StringComparison.OrdinalIgnoreCase);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Performer other = (Performer)obj;
            return string.Equals(firstName, other.firstName, StringComparison.OrdinalIgnoreCase) &&
                   string.Equals(lastName, other.lastName, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(firstName.ToLower(), lastName.ToLower());
        }

        public override string ToString()
        {
            return $"{firstName} {lastName}";
        }
    }

    public class PerformerDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Performance : ICloneable, IComparable<Performance>
    {
        private Performer performer;
        private string title;
        private int duration;

        public Performance(Performer performer, string title, int duration)
        {
            this.performer = performer;
            this.title = title;
            this.duration = duration;
        }

        public Performer Performer
        {
            get { return performer; }
            set { performer = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public object Clone()
        {
            return new Performance((Performer)performer.Clone(), title, duration);
        }

        public int CompareTo(Performance other)
        {
            return duration.CompareTo(other.duration);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Performance other = (Performance)obj;
            return performer.Equals(other.performer) &&
                   string.Equals(title, other.title, StringComparison.OrdinalIgnoreCase) &&
                   duration == other.duration;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(performer.GetHashCode(), title.ToLower(), duration);
        }

        public override string ToString()
        {
            return $"{performer}: {title} ({duration} min)";
        }
    }

    public class PerformanceDTO
    {
        public PerformerDTO Performer { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
    }

    public class Concert : ICloneable, IComparable<Concert>
    {
        private string organizer;
        private DateTime date;
        private List<Performance> performances;

        public Concert(string organizer, DateTime date)
        {
            this.organizer = organizer;
            this.date = date;
            performances = new List<Performance>();
        }

        public string Organizer
        {
            get { return organizer; }
            set { organizer = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public List<Performance> Performances
        {
            get { return performances; }
            set { performances = value; }
        }

        public void AddPerformance(Performance performance)
        {
            performances.Add(performance);
        }

        public object Clone()
        {
            Concert clonedConcert = new Concert(organizer, date);
            foreach (Performance performance in performances)
            {
                clonedConcert.AddPerformance((Performance)performance.Clone());
            }
            return clonedConcert;
        }

        public int CompareTo(Concert other)
        {
            return date.CompareTo(other.date);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Concert other = (Concert)obj;
            return string.Equals(organizer, other.organizer, StringComparison.OrdinalIgnoreCase) &&
                   date.Equals(other.date) &&
                   performances.Count == other.performances.Count &&
                   performances.TrueForAll(p => other.performances.Contains(p));
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(organizer.ToLower(), date.GetHashCode(), performances.Count);
        }

        public override string ToString()
        {
            string concertInfo = $"Concert organized by {organizer} on {date.ToShortDateString()}:\n";
            foreach (Performance performance in performances)
            {
                concertInfo += performance.ToString() + "\n";
            }
            return concertInfo;
        }

        public string ToShortString()
        {
            int totalDuration = 0;
            foreach (Performance performance in performances)
            {
                totalDuration += performance.Duration;
            }
            return $"Concert organized by {organizer}, Duration: {totalDuration} min";
        }
    }

    public class ConcertDTO
    {
        public string Organizer { get; set; }
        public DateTime Date { get; set; }
        public List<PerformanceDTO> Performances { get; set; }
    }
}

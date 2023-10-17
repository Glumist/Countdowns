﻿using System.Xml.Serialization;

namespace Countdowns.Classes
{
    public class Countdown
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private DateTime _endTime;
        public DateTime EndTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }

        public string EndTimeString 
        {
            get 
            {
                if (Math.Abs((EndTime - DateTime.Now).TotalHours) > 24)
                    return EndTime.ToString("d MMMM");
                else if (EndTime.Date < DateTime.Now.Date)
                    return EndTime.ToString("вч HH:mm");
                else if (EndTime.Date > DateTime.Now.Date)
                    return EndTime.ToString("зв HH:mm");
                else
                    return EndTime.ToString("HH:mm");
            }
        }

        private int? _totalMinutes;
        public int? TotalMinutes
        {
            get { return _totalMinutes; }
            set { _totalMinutes = value; }
        }

        private int? _decreaseMinutes;
        public int? DecreaseMinutes
        {
            get { return _decreaseMinutes; }
            set { _decreaseMinutes = value; }
        }

        private BlinkType _blinkType;
        public BlinkType BlinkType
        {
            get { return _blinkType; }
            set { _blinkType = value; }
        }

        private int? _blinkMinutes;
        public int? BlinkMinutes
        {
            get { return _blinkMinutes; }
            set { _blinkMinutes = value; }
        }

        public bool IsBlinking
        {
            get
            {
                return ((BlinkType == BlinkType.AfterEnd && TimeLeft == TimeSpan.Zero) ||
                        (BlinkType == BlinkType.WhileCounting && TimeLeft != TimeSpan.Zero) ||
                        (BlinkType == BlinkType.BeforeEnd && TimeLeft < TimeSpan.FromMinutes(BlinkMinutes.Value)) ||
                        (BlinkType == BlinkType.BeforeAndAfterEnd && (TimeLeft == TimeSpan.Zero || TimeLeft < TimeSpan.FromMinutes(BlinkMinutes.Value)))
                    );
            }
        }

        public TimeSpan TimeLeft 
        {
            get
            {
                if (EndTime > DateTime.Now)
                    return EndTime - DateTime.Now;
                else
                    return TimeSpan.Zero;
            }
        }

        public string TimeLeftString
        {
            get 
            {
                if (TimeLeft.TotalHours >= 1)
                    return string.Format("{0}:{1:00}:{2:00}", Math.Floor(TimeLeft.TotalHours), TimeLeft.Minutes, TimeLeft.Seconds);
                else
                    return string.Format("{0}:{1:00}", TimeLeft.Minutes, TimeLeft.Seconds);
            }
        }

        private Color _color = Color.Gray;
        [XmlIgnore]
        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public int ColorArgb
        {
            get { return Color.ToArgb(); }
            set { Color = Color.FromArgb(value); }
        }

        public Countdown()
        {
            Name = "";
            EndTime = DateTime.Now;
            BlinkType = BlinkType.AfterEnd;
        }

        public override string ToString()
        {
            return Name;
        }

        public static int CompareByDate(Countdown a, Countdown b)
        {
            if (a.EndTime == b.EndTime)
                return string.Compare(a.Name, b.Name);
            return DateTime.Compare(a.EndTime, b.EndTime);
        }
    }


    public class CountdownsCollection
    {
        private static string fileName = "Countdowns.xml";
        private static CountdownsCollection _countdownsCollection;

        private List<Countdown> _countdowns;
        public List<Countdown> Countdowns
        {
            get { return _countdowns; }
            set { _countdowns = value; }
        }

        private CountdownsCollection()
        {
            Countdowns = new List<Countdown>();
        }

        public static CountdownsCollection GetInstance()
        {
            if (_countdownsCollection == null)
                _countdownsCollection = Load();
            return _countdownsCollection;
        }

        public static bool Save()
        {
            GetInstance().Countdowns.Sort(Countdown.CompareByDate);

            try
            {
                XmlHelper.SerializeAndSave(fileName, GetInstance());
                return Check();
            }
            catch
            {
                return false;
            }
        }

        private static bool Check()
        {
            try
            {
                CountdownsCollection toCheck = fileName.LoadAndDeserialize<CountdownsCollection>();
                if (toCheck.Countdowns.Count != GetInstance().Countdowns.Count)
                    return false;
            }
            catch
            {
                return false;
            }
            return true;
        }

        private static CountdownsCollection Load()
        {
            CountdownsCollection result;
            try
            {
                result = fileName.LoadAndDeserialize<CountdownsCollection>();
            }
            catch
            {
                return new CountdownsCollection();
            }

            result.Countdowns.Sort(Countdown.CompareByDate);

            return result;
        }

        public static void Add(Countdown countdown)
        {
            GetInstance().Countdowns.Add(countdown);
            GetInstance().Countdowns.Sort(Countdown.CompareByDate);
        }
    }

    public enum BlinkType
    {
        AfterEnd = 0,
        BeforeEnd = 1,
        BeforeAndAfterEnd = 2,
        WhileCounting = 3,
    }
}
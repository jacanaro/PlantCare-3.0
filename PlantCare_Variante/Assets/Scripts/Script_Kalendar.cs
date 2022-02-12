using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Script_Kalendar : MonoBehaviour
{
    /// <summary>
    /// Zelle im Kalender. Jeder Tag sollte alle Informationen über sich enthalten.
    /// </summary>
    public class Day
    {
        public int dayNum;
        public Color dayColor;
        public GameObject obj;

        /// <summary>
        /// Konstruktor vom Tag
        /// </summary>
        public Day(int dayNum, Color dayColor, GameObject obj)
        {
            this.dayNum = dayNum;
            this.obj = obj;
            UpdateColor(dayColor);
            UpdateDay(dayNum);
        }

        /// <summary>
        /// Wird aufgerufen, um die Farbe der Zelle zu aktualisieren
        /// <param name="newColor">Jeweilige Farbe</param>
        /// </summary>
        public void UpdateColor(Color newColor)
        {
            obj.GetComponent<Image>().color = newColor;
            dayColor = newColor;
        }

        /// <summary>
        /// Je nach Farbe eines Tages wird entschieden, ob dayNum gezeigt wird.
        /// Das führt dazu, dass die Farbe vor dem Tag aktualisiert wird.
        /// </summary>
        public void UpdateDay(int newDayNum)
        {
            this.dayNum = newDayNum;
            if (dayColor == Color.white || dayColor == Color.green)
            {
                obj.GetComponentInChildren<Text>().text = (dayNum + 1).ToString();
            }
            else
            {
                obj.GetComponentInChildren<Text>().text = "";
            }
        }
    }


    private List<Day> days = new List<Day>();

    public Transform[] weeks;

    public Text MonthAndYear;

    public DateTime currDate = DateTime.Now;

    /// <summary>
    /// Kalender wird auf das aktuelle Datum gestellt
    /// </summary>
    private void Start()
    {
        UpdateCalendar(DateTime.Now.Year, DateTime.Now.Month);
    }

    /// <summary>
    /// Jedes mal wenn der Kalender geändert wird, dann wird diese Methode gerufen, um sicherzustellen, dass die richtigen Tage im richtigen Monat/Jahr vorhanden sind
    /// </summary>
    void UpdateCalendar(int year, int month)
    {
        DateTime temp = new DateTime(year, month, 1);
        currDate = temp;
        MonthAndYear.text = temp.ToString("MMMM") + " " + temp.Year.ToString();
        int startDay = GetMonthStartDay(year, month);
        int endDay = GetTotalNumberOfDays(year, month);


        ///Erstellt die Tage
        ///Diese If-Methode führt nur beim kreeiren, des Kalenders aus, um die Tage zu erstellen.

        if (days.Count == 0)
        {
            for (int w = 0; w < 6; w++)
            {
                for (int i = 0; i < 7; i++)
                {
                    Day newDay;
                    int currDay = (w * 7) + i;
                    if (currDay < startDay || currDay - startDay >= endDay)
                    {
                        newDay = new Day(currDay - startDay, Color.grey, weeks[w].GetChild(i).gameObject);
                    }
                    else
                    {
                        newDay = new Day(currDay - startDay, Color.white, weeks[w].GetChild(i).gameObject);
                    }
                    days.Add(newDay);
                }
            }
        }
        ///Looped durch die Tage
        ///Da wir schon die Day-Objekte haben, werden diese einfach geupdatet, statt neue zu erstellen
        else
        {
            for (int i = 0; i < 42; i++)
            {
                if (i < startDay || i - startDay >= endDay)
                {
                    days[i].UpdateColor(Color.grey);
                }
                else
                {
                    days[i].UpdateColor(Color.white);
                }

                days[i].UpdateDay(i - startDay);
            }
        }

        ///Wenn der heutige Tag im Kalender ist wird dieser grün markiert
        if (DateTime.Now.Year == year && DateTime.Now.Month == month)
        {
            days[(DateTime.Now.Day - 1) + startDay].UpdateColor(Color.green);
        }

    }

    /// <summary>
    /// <return>Welcher Tag in der Woche ist der erste im Monat</return>
    /// <param name="month">Jeweiliges Monat als Zahl</param>
    /// <param name="year">Jeweiliges Jahr als Zahl</param>
    /// </summary>
    int GetMonthStartDay(int year, int month)
    {
        DateTime temp = new DateTime(year, month, 1);

        //DayOfWeek Sunday == 0, Saturday == 6 etc.
        return (int)temp.DayOfWeek;
    }

    /// <summary>
    /// <return>Ermittelt die Tage im jeweiligen Monat.</return>
    /// <param name="month">Jeweiliges Monat als Zahl</param>
    /// <param name="year">Jeweiliges Jahr als Zahl</param>
    /// </summary>
    int GetTotalNumberOfDays(int year, int month)
    {
        return DateTime.DaysInMonth(year, month);
    }

    /// <summary>
    /// Fügt einen Monat oder zieht einen Monat von currDate ab/hinzu.
    /// Die Pfeile benutzen diese Funktion, um die Monate zu ändern
    /// <param name="direction">int direction = Jeweiliger Pfeil </param>
    /// </summary>
    public void SwitchMonth(int direction)
    {
        if (direction < 0)
        {
            currDate = currDate.AddMonths(-1);
        }
        else
        {
            currDate = currDate.AddMonths(1);
        }

        UpdateCalendar(currDate.Year, currDate.Month);
    }
}
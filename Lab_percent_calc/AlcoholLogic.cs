using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_percent_calc
{
    class AlcoholLogic
    {
        private float containerSize = 0f,
            alcoholPercentage = 0f;
        private int containerNumber = 0;
        private Dictionary<string, float> alcohols, glasses;

        public AlcoholLogic()
        {
            alcohols = new Dictionary<string, float>
            {
                { "Wino", 12.5f },
                {"Piwo", 5 },
                {"Wódka", 40 },
                {"Cydr", 7 },
                {"Miód pitny", 15 }
            };
            glasses = new Dictionary<string, float>
            {
                {"Kufel mały", 500 },
                {"Kufel średni", 750 },
                {"Kufel duży", 1000 },
                {"Kieliszek mały", 20 },
                {"Kieliszek średni", 50 },
                {"Kieliszek duży", 100 }
            };
        }

        public string[] GetGlassNames()
        {
            return glasses.Keys.ToArray();
        }

        public string[] GetAlcoholNames()
        {
            return alcohols.Keys.ToArray();
        }

        public float GetGlass(string name)
        {
            if (glasses.TryGetValue(name, out float size))
                return size;
            else
                return 0;
        }

        public float GetAlcohol(string name)
        {
            if (alcohols.TryGetValue(name, out float percent))
                return percent;
            else
                return 0;
        }

        public float ContainerSize
        {
            get => containerSize;
            set
            {
                containerSize = value > 0 ? value : 0;
            }
        }
        public float AlcoholPercentage
        {
            get => alcoholPercentage;
            set
            {
                alcoholPercentage = (value > 0 && value < 100) ? value : 0;
            }
        }
        public int ContainerCount
        {
            get => containerNumber;
            set
            {
                containerNumber = value > 0 ? value : 0;
            }
        }
        public float DrinkVolume => ContainerSize * ContainerCount;
        public float AlcoholVolume => ContainerSize * ContainerCount * AlcoholPercentage / 100;
    }
}

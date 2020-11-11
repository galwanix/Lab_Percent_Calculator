using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_percent_calc
{
    class AlcoholLogic
    {
        private float containerSize,
            alcoholPercentage;
        private int containerNumber;

        public AlcoholLogic()
        {
            ContainerCount = 3;
            ContainerSize = 0.75f;
            AlcoholPercentage = 3.5f;
        }

        public float ContainerSize 
        { 
            get => containerSize; 
            set => containerSize = value; 
        }
        public float AlcoholPercentage 
        { 
            get => alcoholPercentage; 
            set => alcoholPercentage = value; 
        }
        public int ContainerCount 
        { 
            get => containerNumber; 
            set => containerNumber = value; 
        }
        public float DrinkVolume => ContainerSize * ContainerCount;
        public float AlcoholVolume => ContainerSize * ContainerCount * AlcoholPercentage / 100;
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Dane, które podaje użytkownik:
 *  1.wielkość naczynia
 *  2.zawartość procentową spirytusu w napoju
 *  3.ilość sztuk "naczynia"
 * Wynikami są:
 *  1.objętość napoju
 *  2.objętość czystego spirytusu
 * Dodatkowo:
 *  1.jedna osoba odpowiada za "logikę" programu, druga za GUI
 *  2.chcemy mieć sensowną historię zmian (tzn. nie na zasadzie,
 *      że mamy tylko jedną dużą zmianę, zawierającą ostateczną wersję)
 * Wersje bogatsze:
 *  1.typowe naczynia (na 4.5)
 *  2.typowe napoje (na 5.5)
 *  3.logika wie wszystko o typowych (na 6)
 */

namespace Lab_percent_calc
{
    public partial class Form1 : Form
    {
        AlcoholLogic logic;

        public Form1()
        {
            InitializeComponent();
            logic = new AlcoholLogic();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            textBoxContainerSize.Text = logic.ContainerSize.ToString();
            textBoxContainerCount.Text = logic.ContainerCount.ToString();
            textBoxAlcoholPercentage.Text = logic.AlcoholPercentage.ToString();
            labelDrinkVolume.Text = logic.DrinkVolume.ToString();
            labelAlcoholVolume.Text = logic.AlcoholVolume.ToString();
        }
    }
}

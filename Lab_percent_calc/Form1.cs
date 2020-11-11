using System;
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
            string[] alcohols = logic.GetAlcoholNames(),
                glasses = logic.GetGlassNames();
            comboBoxAlcohols.Items.Add("Inne");
            comboBoxGlasses.Items.Add("Inne");
            comboBoxAlcohols.SelectedIndex = 0;
            comboBoxGlasses.SelectedIndex = 0;
            foreach (string s in alcohols)
                comboBoxAlcohols.Items.Add(s);
            foreach (string s in glasses)
                comboBoxGlasses.Items.Add(s);
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(textBoxContainerSize.Text, out float size))
            {
                labelErrors.Text = "Błąd odczytu rozmiaru naczynia.";
                return;
            }
            if (!float.TryParse(textBoxAlcoholPercentage.Text, out float percentage))
            {
                labelErrors.Text = "Błąd odczytu zawartości alkoholu.";
                return;
            }
            if (!int.TryParse(textBoxContainerCount.Text, out int count))
            {
                labelErrors.Text = "Błąd odczytu ilości naczyń.";
                return;
            }
            labelErrors.Text = "";
            logic.AlcoholPercentage = percentage;
            logic.ContainerCount = count;
            logic.ContainerSize = size;
            labelDrinkVolume.Text = logic.DrinkVolume.ToString();
            labelAlcoholVolume.Text = logic.AlcoholVolume.ToString();
        }

        private void comboBoxGlasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxGlasses.SelectedIndex == 0)
            {
                textBoxContainerSize.Enabled = true;
                textBoxContainerSize.Text = "";
            }
            else
            {
                textBoxContainerSize.Enabled = false;
                textBoxContainerSize.Text = logic.GetGlass((string)comboBoxGlasses.SelectedItem).ToString();
            }
        }

        private void comboBoxAlcohols_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAlcohols.SelectedIndex == 0)
            {
                textBoxAlcoholPercentage.Enabled = true;
                textBoxAlcoholPercentage.Text = "";
            }
            else
            {
                textBoxAlcoholPercentage.Enabled = false;
                textBoxAlcoholPercentage.Text = logic.GetAlcohol((string)comboBoxAlcohols.SelectedItem).ToString();
            }
        }
    }
}

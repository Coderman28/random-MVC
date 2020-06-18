using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RANDOM_MVC
{
    class randomGenerotor
    {

        private Label text;
        private Button button;
        private int min;
        private int max;

        public randomGenerotor(Label texte, Button buttone, int mine, int maxe)
        {
            text = texte;
            button = buttone;
            min = mine;
            max = maxe;
        }

        public void ChangeText()
        {
            Random randomNumber = new Random();

            int number = randomNumber.Next(min, max);

            text.Text = "voici le nouveau nombre : " + number;
        }

    }
}

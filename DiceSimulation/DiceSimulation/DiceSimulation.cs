using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceSimulation
{
    public partial class DiceSimulation : Form
    {
        public DiceSimulation()
        {
            InitializeComponent();
        }

        private void rollDice_Click(object sender, EventArgs e)
        {
            Random randNum = new Random();
            int firstDie; 
            int secondDie;

            for (int i = 1; i <= 100; i++)
            {
                firstDie = randNum.Next(1, 7);
                secondDie = randNum.Next(1, 7);
                string[] row = { firstDie.ToString(), secondDie.ToString(), i.ToString() };
                var listViewItem = new ListViewItem(row);
                if (firstDie == secondDie)
                {
                    resultsView.Items.Add(listViewItem);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_DHondt_Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] mandates;
        int[] votes;
        float[] calcTab;
        TextBox[] textBoxes;
        int partiesAmount;
        int mandatesAmount;
        int maxind;
        float max;

        private void bt_GetMandatesOfEachParty_Click(object sender, EventArgs e)
        {
            partiesAmount = 0;
            mandatesAmount = 0;
            int.TryParse(tb_NumberOfParties.Text, out partiesAmount);
            int.TryParse(tb_NumberOfMandates.Text, out mandatesAmount);

            if (partiesAmount > 0 && mandatesAmount > 0)
            {
                var x = groupBox1.Location.X ;
                var y = groupBox1.Location.Y + groupBox1.Height;
                mandates = new int[partiesAmount];
                votes = new int[partiesAmount];
                calcTab = new float[partiesAmount];

                textBoxes = new TextBox[partiesAmount];
                Label[] labels = new Label[partiesAmount];

                for (int i = 0; i < textBoxes.Length; i++)
                {
                    labels[i] = new Label();
                    labels[i].Location = new Point( x, y+=20);
                    labels[i].Text = $"Party nr{i + 1}";
                    textBoxes[i] = new TextBox();
                    textBoxes[i].Name = $"Party{i + 1}";
                    textBoxes[i].Location = new Point(x, y += 20);                    
                }
                for (int i = 0; i < textBoxes.Length; i++)
                {
                    this.Controls.Add(labels[i]);
                    this.Controls.Add(textBoxes[i]);
                }

                Button button = new Button();
                button.Location = new Point(x, y += 20);
                button.Text = $"Get data to matrix analysis";
                button.Click += new EventHandler(getDataForAnalysis);
                this.Controls.Add(button);
            }
        }

        private static float calcNewValue(int votes, int mandates)
        {
            return (float)((votes * 1.0) / (mandates + 1.0));
        }

        protected void getDataForAnalysis(object sender, EventArgs e)
        {
            this.Visible = true;
            for (int i = 0; i < textBoxes.Length; i++)
            {
                int vote = 0;
                TextBox item = (TextBox)textBoxes[i];
                int.TryParse(item.Text, out vote);
                votes[i] = vote;
            }            

            for (int i = 0; i < partiesAmount; i++)
            {
                mandates[i] = 0;
            }

            for (int i = 0; i < partiesAmount; i++)
            {
                calcTab[i] = votes[i];
            }
            for (int i = 0; i < mandatesAmount; i++)
            {
                max = -1;
                for (int j = 0; j < partiesAmount; j++)
                {
                    if(max < calcTab[j])
                    {
                        max = calcTab[j];
                        maxind = j;
                    }
                }
                mandates[maxind]++;
                calcTab[maxind] = calcNewValue(votes[maxind], mandates[maxind]);
            }
            for (int i = 0; i < partiesAmount; i++)
            {
                tb_Output.AppendText($"Party{i + 1} has {mandates[i]} mandates{Environment.NewLine}");                
            }
        }
    }
    

}

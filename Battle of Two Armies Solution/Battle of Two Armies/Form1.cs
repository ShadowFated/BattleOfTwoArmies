using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battle_of_Two_Armies
{
    public partial class BattleOfTwoArmies : Form
    {
        public BattleOfTwoArmies()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(133, 133, 141);
            button1.Enabled = false;
            button1.Text = "In Progress";

            //Assemble Armies Message.
            richTextBox1.Text = MobilizeMessageAllie(richTextBox1.Text);
            richTextBox2.Text = MobilizeMessageAxis(richTextBox2.Text);

            //Random Number Generator.
            Random random = new Random();
            int randomNumber1 = random.Next(0, 100);
            int randomNumber2 = random.Next(0, 100);
            int randomNumber3 = random.Next(0, 100);
            int randomNumber4 = random.Next(0, 100);
            int randomNumber5 = random.Next(0, 100);
            int randomNumber6 = random.Next(0, 100);

            //Miltary Unit Base Values. 
            const int plane = 15;
            const int tank = 10;
            const int soldier = 5;

            //Military Unit Strengths. 
            int AllieArmyTank = ((randomNumber1) * (tank));
            int AllieArmyPlane = ((randomNumber2) * (plane));
            int AllieArmySoldier = ((randomNumber3) * (soldier));
            int AllieArmyTotal = (AllieArmyTank + AllieArmyPlane + AllieArmySoldier);

            int AxisArmyTank = ((randomNumber4) * (tank));
            int AxisArmyPlane = ((randomNumber5) * (plane));
            int AxisArmySoldier = ((randomNumber6) * (soldier));
            int AxisArmyTotal = (AxisArmyTank + AxisArmyPlane + AxisArmySoldier);

            //Assembling Armies.

            allieplanepicture.Visible = true;
            allieplaneTextbox.Visible = true;
            allieplaneTextbox.Text = ("Unit Strength: " + AllieArmyPlane);
            axisplanepicture.Visible = true;
            axisplaneTextbox.Visible = true;
            axisplaneTextbox.Text = ("Unit Strength: " + AxisArmyPlane);

            alliesoldierpicture.Visible = true;
            alliesoldierTextbox.Visible = true;
            alliesoldierTextbox.Text = ("Unit Strength: " + AllieArmySoldier);
            axissoldierpicture.Visible = true;
            axissoldierTextbox.Visible = true;
            axissoldierTextbox.Text = ("Unit Strength: " + AxisArmySoldier);

            allietankpicture.Visible = true;
            allietankTextbox.Visible = true;
            allietankTextbox.Text = ("Unit Strength: " + AllieArmyTank);
            axistankpicture.Visible = true;
            axistankTextbox.Visible = true;
            axistankTextbox.Text = ("Unit Strength: " + AxisArmyTank);

            //Engaging Armies Message.
            Task.Delay(3000).Wait();
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox1.Text = EngagingAllie(richTextBox1.Text);
            richTextBox2.Text = EngagingAxis(richTextBox2.Text);

            allieplaneshellpicture.Visible = true;
            axisplaneshellpicture.Visible = true;
            allietankshellpicture.Visible = true;
            axistankshellpicture.Visible = true;
            alliesoldiershellpicture.Visible = true;
            axissoldiershellpicture.Visible = true;

            Task.Delay(4000).Wait();


            //Comparing Unit Strengths 
            int AllievsAxisPlane = AllieArmyPlane.CompareTo(AxisArmyPlane);
            if (AllievsAxisPlane > 0)
            {
                int AlliePlaneRemain = (AllieArmyPlane - AxisArmyPlane);
                allieplaneTextbox.Clear();
                allieplaneTextbox.Clear();
                axisplaneTextbox.Text = ("KIA");
                allieplaneTextbox.Text = ("Unit Strength: " + AlliePlaneRemain);
                axisplaneXpicture.Visible = true;
            }
            else if (AllievsAxisPlane == 0)
            {

                allieplaneTextbox.Clear();
                allieplaneTextbox.Clear();
                allieplaneTextbox.Text = ("KIA");
                axisplaneXpicture.Visible = true;
                allieplaneXpicture.Visible = true;
            }
            else
            {
                int AxisPlaneRemain = (AxisArmyPlane - AllieArmyPlane);
                allieplaneTextbox.Clear();
                allieplaneTextbox.Clear();
                allieplaneTextbox.Text = ("KIA");
                axisplaneTextbox.Text = ("Unit Strength: " + AxisPlaneRemain);
                allieplaneXpicture.Visible = true;
            }
            
            int AllievsAxisTank = AllieArmyTank.CompareTo(AxisArmyTank);
            if (AllievsAxisTank > 0)
            {
                int AllieTankRemain = (AllieArmyTank - AxisArmyTank);
                allietankTextbox.Clear();
                allietankTextbox.Clear();
                axistankTextbox.Text = ("KIA");
                allietankTextbox.Text = ("Unit Strength: " + AllieTankRemain);
                axistankXpicture.Visible = true;
            }
            else if (AllievsAxisTank == 0)
            {
                allietankTextbox.Clear();
                allietankTextbox.Clear();
                allietankTextbox.Text = ("KIA");
                axistankXpicture.Visible = true;
                allietankXpicture.Visible = true;
            }
            else
            {
                int AxisTankRemain = (AxisArmyTank - AllieArmyTank);
                allietankTextbox.Clear();
                allietankTextbox.Clear();
                allietankTextbox.Text = ("KIA");
                axistankTextbox.Text = ("Unit Strength: " + AxisTankRemain);
                allietankXpicture.Visible = true;
            }

            int AllievsAxisSoldier = AllieArmySoldier.CompareTo(AxisArmySoldier);
            if (AllievsAxisSoldier > 0)
            {
                int AllieSoldierRemain = (AllieArmySoldier - AxisArmySoldier);
                alliesoldierTextbox.Clear();
                alliesoldierTextbox.Clear();
                axissoldierTextbox.Text = ("KIA");
                alliesoldierTextbox.Text = ("Unit Strength: " + AllieSoldierRemain);
                axissoldierXpicture.Visible = true;
            }
            else if (AllievsAxisSoldier == 0)
            {
                alliesoldierTextbox.Clear();
                alliesoldierTextbox.Clear();
                alliesoldierTextbox.Text = ("KIA");
                axissoldierXpicture.Visible = true;
                alliesoldierXpicture.Visible = true;
            }
            else
            {
                int AxisSoldierRemain = (AxisArmySoldier - AllieArmySoldier);
                alliesoldierTextbox.Clear();
                alliesoldierTextbox.Clear();
                alliesoldierTextbox.Text = ("KIA");
                axissoldierTextbox.Text = ("Unit Strength: " + AxisSoldierRemain);
                alliesoldierXpicture.Visible = true;
            }


            //Disable Bullets
            allieplaneshellpicture.Visible = false;
            axisplaneshellpicture.Visible = false;
            allietankshellpicture.Visible = false;
            axistankshellpicture.Visible = false;
            alliesoldiershellpicture.Visible = false;
            axissoldiershellpicture.Visible = false;

            //Display Battle Results in Button
            Task.Delay(2000).Wait();

            int AllievsAxisResult = AllieArmyTotal.CompareTo(AxisArmyTotal);
            if (AllievsAxisResult > 0)
            {
                button1.BackColor = Color.FromArgb(252, 180, 21);
                richTextBox1.Clear();
                richTextBox2.Clear();
                richTextBox1.Text = AlliesWin(richTextBox1.Text);
                richTextBox2.Text = AxisLoose(richTextBox2.Text);
                button1.Text = "Allies Win!";
            }
            else if (AllievsAxisResult == 0)
            {
                button1.BackColor = Color.FromArgb(252, 180, 21);
                richTextBox1.Clear();
                richTextBox2.Clear();
                richTextBox1.Text = AlliesTie(richTextBox1.Text);
                richTextBox2.Text = AxisTie(richTextBox2.Text);
                button1.Text = "It's a tie!";
            }
            else
            {
                button1.BackColor = Color.FromArgb(252, 180, 21);
                richTextBox1.Clear();
                richTextBox2.Clear();
                richTextBox1.Text = AlliesLoose(richTextBox1.Text);
                richTextBox2.Text = AxisWin(richTextBox2.Text);
                button1.Text = "Axis Win!";
            }

               
        }

        //All Messages
        private string MobilizeMessageAllie(string str)
        {
            string result = "Forces are mobilizing! " + str;
            return result;
        }

        private string MobilizeMessageAxis(string str)
        {
            string result = "Kräfte mobilisieren!" + str;
            return result;
        }

        private string EngagingAllie(string str)
        {
            string result = "Engaging the enemy! " + str;
            return result;
        }
        private string EngagingAxis(string str)
        {
            string result = "Das Engagement der Feind! " + str;
            return result;
        }

        private string AlliesWin(string str)
        {
            string result = "Victory is ours! " + str;
            return result;
        }
        private string AxisWin(string str)
        {
            string result = "Der Sieg ist unser! " + str;
            return result;
        }

        private string AlliesLoose(string str)
        {
            string result = "We Lost! " + str;
            return result;
        }
        private string AxisLoose(string str)
        {
            string result = "Nein, nein, nein! " + str;
            return result;
        }

        private string AlliesTie(string str)
        {
            string result = "Its a tie! " + str;
            return result;
        }
        private string AxisTie(string str)
        {
            string result = "Es ist eine Krawatte! " + str;
            return result;
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void allietankpicture_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void axistankTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void battlefield_Paint(object sender, PaintEventArgs e)
        {

        }

        private void allieplaneshellpicture_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void axisplaneXpicture_Click(object sender, EventArgs e)
        {

        }

        private void axistankXpicture_Click(object sender, EventArgs e)
        {

        }
    }
}

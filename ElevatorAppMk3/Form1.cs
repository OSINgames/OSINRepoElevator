using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorAppMk3
{
    public partial class Form1 : Form
    {
        private const int V = 237;
        private const int V1 = 160;
        private const int V2 = 60;
        private const int V3 = 545;
        public int closing_stop = V;
        public int opening_stop = V1;
        public int first_stop = V2;
        public int ground_stop = V3;

        public int display_visibility;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void openDrBtn_Click(object sender, EventArgs e)
        {
            if (elevator.Top >= V2)
                this.timer4.Enabled = true;// Opening doors from elevator panel
            if (elevator.Top <= V3)
                this.timer5.Enabled = true;

        }

        private void closeDrBtn_Click(object sender, EventArgs e)
        {
            if (elevator.Top >= V2)
                this.timer3.Enabled = true;// Closing doors from elvator panel
            if (elevator.Top <= V3)
                this.timer5.Enabled = true;

        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;// Button that allows to stop elevator motion.
            this.timer2.Enabled = false;

        }

        private void firstFlBtn_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            this.timer6.Enabled = true;
            groundFloorDisplay0.Visible = false;
            groundFloorDisplay1.Visible = true;
            elevatorDisplay0.Visible = false;
            firstFloorDisplay0.Visible = false;
            firstFloorDisplay1.Visible = true;
            elevatorDisplay1.Visible = false;


        }

        private void buttonFirstRqst_Click(object sender, EventArgs e)
        {
            this.timer2.Enabled = true;
            this.timer6.Enabled = true;
            groundFloorDisplay0.Visible = false;
            groundFloorDisplay1.Visible = true;
            elevatorDisplay0.Visible = false;
            firstFloorDisplay0.Visible = false;
            firstFloorDisplay1.Visible = true;
            elevatorDisplay0.Visible = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.timer2.Enabled = true;
            this.timer6.Enabled = true;
            groundFloorDisplay0.Visible = true;
            groundFloorDisplay1.Visible = false;
            elevatorDisplay0.Visible = true;
            firstFloorDisplay0.Visible = true;
            firstFloorDisplay1.Visible = false;
            elevatorDisplay0.Visible = true;

        }

        private void buttonGroundRequest_Click(object sender, EventArgs e)
        {
            this.timer2.Enabled = true;
            this.timer6.Enabled = true;
            groundFloorDisplay0.Visible = true;
            groundFloorDisplay1.Visible = false;
            elevatorDisplay0.Visible = true;
            firstFloorDisplay0.Visible = true;
            firstFloorDisplay1.Visible = false;
            elevatorDisplay0.Visible = true;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.elevator.Top--;


            if (this.elevator.Top <= V2)// Animation of lift going up
            {
                this.timer1.Enabled = false;
            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.elevator.Top++;

            if (this.elevator.Top >= V3)//Animation of lift going down
            {

                this.timer2.Enabled = false;
            }


        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            this.groundFloorLDoor.Left++;// Closing ground floor doors
            this.groundFloorRDoor.Left--;
            this.timer4.Enabled = false;


            if (this.groundFloorLDoor.Left == V)
            {
                this.timer3.Enabled = false;
            }


        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            this.groundFloorLDoor.Left--;// Opening ground floor doors
            this.groundFloorRDoor.Left++;
            this.timer3.Enabled = false;

            if (this.groundFloorLDoor.Left == V1)
            {
                this.timer4.Enabled = false;
            }

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            this.firstFloorLDoor.Left--;// Opening doors on first floor
            this.firstFloorRDoor.Left++;

            if (this.firstFloorLDoor.Left == V1)
            {
                this.timer5.Enabled = false;
            }

        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            this.firstFloorLDoor.Left++;// Closing doors on first floor
            this.firstFloorRDoor.Left--;

            if (this.firstFloorLDoor.Left >= V)
            {
                this.timer6.Enabled = false;
            }

        }
    }
}

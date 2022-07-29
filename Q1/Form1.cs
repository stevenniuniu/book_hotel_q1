using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Text = "";
        }

        //Array for Room Status
        //0 occupied, 1 vacant, 2 available, 3 repair
        int[] room = {  2,2,2,2,2,//1A to 1E
                            0,0,0,0,0,//2E to 2A
                            1,0,3,0,1,//3A to 3E
                            0,0,2,0,0 //4E to 4A
                         };
        string[] room_str = { "1A","1B","1C","1D","1E",
                                "2E","2D","2C","2B","2A",
                                "3A","3B","3C","3D","3E",
                                "4E","4D","4C","4B","4A"
        };

        int selected_room = 0;
        int num_room = 20;

        //Check In
        private void button1_Click(object sender, EventArgs e)
        {
            if (room[selected_room] == 2)//2 available
            {
                room[selected_room] = 0;//0 occupied
            }
            else
            { 
                //TODO:
            }
        }

        //Check Out
        private void button2_Click(object sender, EventArgs e)
        {
            if (room[selected_room] == 0)//0 occupied
            {
                room[selected_room] = 1;//1 vacant
            }
            else
            {
                //TODO:
            }
        }

        //Clean
        private void button3_Click(object sender, EventArgs e)
        {
            if (room[selected_room] == 1)//1 vacant
            {
                room[selected_room] = 2;//2 available
            }
            else
            {
                //TODO:
            }
        }

        //Out of Service
        private void button4_Click(object sender, EventArgs e)
        {
            if (room[selected_room] == 1)//1 vacant
            {
                room[selected_room] = 3;//3 repair
            }
            else
            {
                //TODO:
            }
        }

        //Repair
        private void button5_Click(object sender, EventArgs e)
        {
            if (room[selected_room] == 3)//3 repair
            {
                room[selected_room] = 1;//1 vacant
            }
            else
            {
                //TODO:
            }

            //test code
            //string[] result = Array.ConvertAll(room, x => x.ToString());
            //textBox1.Text = String.Concat(result);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = comboBox1.Text;

            //Convert String to Index
            switch (label3.Text) {
                case "1A":
                    selected_room = 0;
                    break;
                case "1B":
                    selected_room = 1;
                    break;
                case "1C":
                    selected_room = 2;
                    break;
                case "1D":
                    selected_room = 3;
                    break;
                case "1E":
                    selected_room = 4;
                    break;
                case "2E":
                    selected_room = 5;
                    break;
                case "2D":
                    selected_room = 6;
                    break;
                case "2C":
                    selected_room = 7;
                    break;
                case "2B":
                    selected_room = 8;
                    break;
                case "2A":
                    selected_room = 9;
                    break;
                case "3A":
                    selected_room = 10;
                    break;
                case "3B":
                    selected_room = 11;
                    break;
                case "3C":
                    selected_room = 12;
                    break;
                case "3D":
                    selected_room = 13;
                    break;
                case "3E":
                    selected_room = 14;
                    break;
                case "4A":
                    selected_room = 15;
                    break;
                case "4B":
                    selected_room = 16;
                    break;
                case "4C":
                    selected_room = 17;
                    break;
                case "4D":
                    selected_room = 18;
                    break;
                case "4E":
                    selected_room = 19;
                    break;

                default:
                    break;

            }

        }

        //Show available
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            for (int i = 0; i < num_room; i++)
            {
                if (room[i] == 2)
                {
                    textBox1.Text += room_str[i] + " ";
                }

            }
        }

        //show occupied
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            for (int i = 0; i < num_room; i++)
            {
                if (room[i] == 0)
                {
                    textBox1.Text += room_str[i] + " ";
                }

            }
        }

        //show vacant
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            for (int i = 0; i < num_room; i++)
            {
                if (room[i] == 1)
                {
                    textBox1.Text += room_str[i] + " ";
                }

            }
        }

        //show repair
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            for (int i = 0; i < num_room; i++)
            {
                if (room[i] == 3)
                {
                    textBox1.Text += room_str[i] + " ";
                }

            }
        }
    }
}

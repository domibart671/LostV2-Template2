/// created by : 
/// date       : 
/// description: A basic text adventure game engine

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  

namespace LostV2
{
    public partial class Form1 : Form
    {
        // tracks what part of the game the user is at
        int scene = 0;  

       

        public Form1()
        {
            InitializeComponent();

            outputLabel.Text = "You wake up at an abandoned hospital.There is a man right beside you";
            redLabel.Text = "Trust the man";
            blueLabel.Text = "Dont trust the man";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 0)
                {
                    scene = 1;
                }
                else if (scene == 1)
                {
                    scene = 4;
                }
                else if (scene == 2)
                {
                    scene = 0;
                }
                else if (scene == 3)
                {
                    scene = 0;
                }
                else if (scene == 4)
                {
                    scene = 6;
                }
                else if (scene == 5)
                {
                    scene = 0;
                }
                else if (scene == 6)
                {
                    scene = 9;
                }
                else if (scene == 7)
                {
                    scene = 13;
                }
                else if (scene == 8)
                {
                   
                }
                else if (scene == 9)
                {
                    scene = 11;
                }
                else if (scene == 10)
                {
                    scene = 0;
                }
                else if (scene == 11)
                {
                    scene = 0;
                }
                else if (scene == 12)
                {
                    scene = 0;
                }
                else if (scene == 13)
                {
                    scene = 15;
                }
                else if (scene == 14)
                {
                    scene = 0;
                }
                else if (scene == 15)
                {
                    scene = 17;
                }
                else if (scene == 16)
                {
                    scene = 0;
                }
                else if (scene == 17)
                {
                    scene = 18;
                }
                else if (scene == 18)
                {
                    scene = 18;
                }
            }

            if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 0)
                {
                    scene = 2;
                }
                else if (scene == 1)
                {
                    scene = 3;
                }
                else if (scene == 2)
                {
                    scene = 18;
                }
                else if (scene == 3)
                {
                    scene = 18;
                }
                else if (scene == 4)
                {
                    scene = 5;
                }
                else if (scene == 5)
                {
                    scene = 18;
                }
                else if (scene == 6)
                {
                    scene = 7;
                }
                else if (scene == 7)
                {
                    scene = 12;
                }
                else if (scene == 8)
                {
                    
                }
                else if (scene == 9)
                {
                    scene = 10;
                }
                else if (scene == 10)
                {
                    scene = 18;
                }
                else if (scene == 11)
                {
                    scene = 18;
                }
                else if (scene == 12)
                {
                    scene = 18;
                }
                else if (scene == 13)
                {
                    scene = 14;
                }
                else if (scene == 14)
                {
                    scene = 18;
                }
                else if (scene == 15)
                {
                    scene = 16;
                }
                else if (scene == 16)
                {
                    scene = 18;
                }
                else if (scene == 17)
                {
                    scene = 18;
                }
                else if (scene == 18)
                {
                    scene = 18;
                }
            }

            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                case 0:
                    outputLabel.Text = "You wake up at an abandoned hospital.There is a man right beside you";
                    redLabel.Text = "Trust the man";
                    blueLabel.Text = "Dont trust the man";
                    break;
                case 1:
                    outputLabel.Text = "He helps you. He asks you to go to his car Do you go ? ";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 2:
                    outputLabel.Text = "He grabs a knife and stabs you, do you want to play again? ";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 3:
                    outputLabel.Text = "he cuffs you and puts a grenade beside you You die, Do you want to play again? ";
                    redLabel.Text ="Yes" ;
                    blueLabel.Text = "No" ; 
                    break;
                case 4:
                    outputLabel.Text = "You arrive at his car";
                    redLabel.Text = "Try to get out";
                    blueLabel.Text = "Stay";
                    break;
                case 5:
                    outputLabel.Text = "you open the door and fell in a hole and hurt your legs, do you want to play again? ";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 6:
                    outputLabel.Text = "you arrive and he left you in the car";
                    redLabel.Text = "Stay in car";
                    blueLabel.Text = "Try to run away";
                    break;
                case 7:
                    outputLabel.Text = "you ran safety away and found a abandoned trailer";
                    redLabel.Text = "Go inside";
                    blueLabel.Text = "Keep running";
                    break;
                case 9:
                    outputLabel.Text = "you stayed and he brought you inside.You saw a knife at the front door.";
                    redLabel.Text = "Leave it";
                    blueLabel.Text = "Grab the knife";
                    break;
                case 10:
                    outputLabel.Text = "you grabbed it and he saw you and his K - 9 came after you and you died, do you want to play again? ";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 11:
                    outputLabel.Text = "you looked at the knife and left it, but you made eye contact with him and he jumped you, do you want to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 12:
                    outputLabel.Text = "the man's dog found you and bites your feet, do you want to play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 13:
                    outputLabel.Text = "You see food and water, but someone is coming";
                    redLabel.Text = "Hide";
                    blueLabel.Text = "Talk to her";
                    break;
                case 14:
                    outputLabel.Text = "you came out of the trailer and she shoots you, do you want to play again? ";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 15:
                    outputLabel.Text = "you hid below the sink. She drops her car keys near you and went to sleep ";
                    redLabel.Text = "Drive away";
                    blueLabel.Text = "Open door";
                    break;
                case 16:
                    outputLabel.Text = "You opened the door and it was lock, so you woke her up and got caught, do you want to play again? ";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 17:
                    outputLabel.Text = "you drove away  safety and got out of the town.You arrived at a police station  ";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 18:
                    outputLabel.Text = "Thank you for playing   ";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OutputLabel_Click(object sender, EventArgs e)
        {

        }
    }

}

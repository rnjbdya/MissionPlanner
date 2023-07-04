using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; // for Sleep

namespace MissionPlanner
{
    public partial class controlMultipleRelays : Form
    {
        //int leftButtonState[5] = { 0, 0, 0, 0, 0 };// error
        int[] arr00000 = new int[5] { 0, 0, 0, 0, 0 };
        int[] arr00001 = new int[5] { 0, 0, 0, 0, 1 };
        int[] arr00010 = new int[5] { 0, 0, 0, 1, 0 };
        int[] arr00011 = new int[5] { 0, 0, 0, 1, 1 };
        int[] arr00100 = new int[5] { 0, 0, 1, 0, 0 };
        int[] arr00101 = new int[5] { 0, 0, 1, 0, 1 };
        int[] arr00110 = new int[5] { 0, 0, 1, 1, 0 };
        int[] arr00111 = new int[5] { 0, 0, 1, 1, 1 };
        int[] arr01000 = new int[5] { 0, 1, 0, 0, 0 };
        int[] arr01001 = new int[5] { 0, 1, 0, 0, 1 };
        
        int[] arr01010 = new int[5] { 0, 1, 0, 1, 0 };
        int[] arr01011 = new int[5] { 0, 1, 0, 1, 1 };
        int[] arr01100 = new int[5] { 0, 1, 1, 0, 0 };
        int[] arr01101 = new int[5] { 0, 1, 1, 0, 1 };
        int[] arr01110 = new int[5] { 0, 1, 1, 1, 0 };
        int[] arr01111 = new int[5] { 0, 1, 1, 1, 1 };
        int[] arr10000 = new int[5] { 1, 0, 0, 0, 0 };
        int[] arr10001 = new int[5] { 1, 0, 0, 0, 1 };
        int[] arr10010 = new int[5] { 1, 0, 0, 1, 0 };
        int[] arr10011 = new int[5] { 1, 0, 0, 1, 1 };

        int[] arr10100 = new int[5] { 1, 0, 1, 0, 0 };
        int[] arr10101 = new int[5] { 1, 0, 1, 0, 1 };
        int[] arr10110 = new int[5] { 1, 0, 1, 1, 0 };
        int[] arr10111 = new int[5] { 1, 0, 1, 1, 1 };
        int[] arr11000 = new int[5] { 1, 1, 0, 0, 0 };
        int[] arr11001 = new int[5] { 1, 1, 0, 0, 1 };
        int[] arr11010 = new int[5] { 1, 1, 0, 1, 0 };
        int[] arr11011 = new int[5] { 1, 1, 0, 1, 1 };
        int[] arr11100 = new int[5] { 1, 1, 1, 0, 0 };
        int[] arr11101 = new int[5] { 1, 1, 1, 0, 1 };

        int[] arr11110 = new int[5] { 1, 1, 1, 1, 0 };
        int[] arr11111 = new int[5] { 1, 1, 1, 1, 1 };


        public static bool checkEquality<T>(T[] first, T[] second)
        {
            return Enumerable.SequenceEqual(first, second);
        }


        // button state 
        // 0 : not ready
        // 1 : ready
        // 2 : fired
        public static bool checkTrueBitEqulity(int[] first, int[] buttonArr)
        {
            for (int i=0; i<5; i++) 
            {                            // 0,1,0,0,1
                if ( 1 == buttonArr[i] ) // 2,1,0,0,1
                {
                    if ( first[i] != buttonArr[i] )
                    {
                        return false;
                    }
                }  
            }
            return true;
        }

        int PWM = 0;
        int[] leftButtonState = new int[5] { 0, 0, 0, 0, 0 };
        int[] rightButtonState = new int[5] { 0, 0, 0, 0, 0 };
        bool isLeftOn = false; // Last Launch Button
        bool isRightOn = false;// Last Launch Button
        int cntLeftBullets = 5;
        int cntRightBullets = 5;

        bool isLeft_1_Fired = false;
        bool isLeft_2_Fired = false;
        bool isLeft_3_Fired = false;
        bool isLeft_4_Fired = false;
        bool isLeft_5_Fired = false;
        bool isLeft_All_Fired = false;
        
        bool isRight_1_Fired = false;
        bool isRight_2_Fired = false;
        bool isRight_3_Fired = false;
        bool isRight_4_Fired = false;
        bool isRight_5_Fired = false;
        bool isRight_All_Fired = false;
        

        private const int RELEASE_SERVO_NUM = 12;
        public controlMultipleRelays()
        {
            InitializeComponent();

            this.ControlBox = false; // disable close button
            /*
            https://social.msdn.microsoft.com/Forums/en-US/b1f0d913-c603-43e9-8fe3-681fb7286d4c/c-disable-close-button-on-windows-form-application?forum=csharpgeneral
            */
        }

        void buttonStateUpdate(string _when)
        {   
            // Left Button update------------------------------------------------------
            if(_when == "After Left Side Launch")
            {
                for (int i = 0; i < 5; i++)
                {
                    if (1 == leftButtonState[i]) // ready -> fired
                    {
                        leftButtonState[i] = 2;
                        if (0 == i) { leftOne.Text      = "fired"; }
                        if (1 == i) { leftTwo.Text      = "fired"; }
                        if (2 == i) { leftThree.Text    = "fired"; }
                        if (3 == i) { leftFour.Text     = "fired"; }
                        if (4 == i) { leftFive.Text     = "fired"; }
                        
                        cntLeftBullets--;
                        if ( 0 == cntLeftBullets)
                        {
                            leftAll.Text = "All fired";
                            
                        }                      
                    }
                }
                return;
            }

            else if( (_when == "After Left Side Reset") && ( 0 == cntLeftBullets ) )
            {
                for (int i = 0; i < 5; i++)
                {
                    leftButtonState[i] = 0;
                }
                leftOne.Text    = "1";
                leftTwo.Text    = "2";
                leftThree.Text  = "3";
                leftFour.Text   = "4";
                leftFive.Text   = "5";
                leftAll.Text    = "Select All";
                cntLeftBullets  = 5;
                return;
            }
            
            //  Rigth Button Update---------------------------------------------------
            else if (_when == "After Right Side Launch")
            {
                for (int i = 0; i < 5; i++)
                {
                    if (1 == rightButtonState[i]) // ready -> fired
                    {
                        rightButtonState[i] = 2;
                        if (0 == i) { rightOne.Text = "fired"; }
                        if (1 == i) { rightTwo.Text = "fired"; }
                        if (2 == i) { rightThree.Text = "fired"; }
                        if (3 == i) { rightFour.Text = "fired"; }
                        if (4 == i) { rightFive.Text = "fired"; }

                        cntRightBullets--;
                        if (0 == cntRightBullets)
                        {
                            rightAll.Text = "All fired";
                        }
                    }
                }
                return;
            }

            else if ( (_when == "After Right Side Reset") && ( 0 == cntRightBullets) )
            {
                for (int i = 0; i < 5; i++)
                {
                    rightButtonState[i] = 0;
                }
                rightOne.Text   = "1";
                rightTwo.Text   = "2";
                rightThree.Text = "3";
                rightFour.Text  = "4";
                rightFive.Text  = "5";
                rightAll.Text = "Select All";
                cntRightBullets = 5;
                return;
            }
        }

        void sendPWMtoFC(int _pwm)
        {
            try
            {
                if (MainV2.comPort.doCommand((byte)MainV2.comPort.sysidcurrent, (byte)MainV2.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, RELEASE_SERVO_NUM, _pwm, 0, 0,
                    0, 0, 0))
                {
                   // Do nothing
                }
                else
                {
                    CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR);
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(Strings.CommandFailed + ex.ToString(), Strings.ERROR);
            }
            
        }

        // TODO: change the button color 
        //--------------------- Left Side  ------------------------
        // push return switch
        private void leftAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                if (0 == leftButtonState[i]) //button number -> ready
                {    
                    leftButtonState[i] = 1;
                    if (0 == i) { leftOne.Text = "Ready"; }
                    if (1 == i) { leftTwo.Text = "Ready"; }
                    if (2 == i) { leftThree.Text = "Ready"; }
                    if (3 == i) { leftFour.Text = "Ready"; }
                    if (4 == i) { leftFive.Text = "Ready"; }
                }
            }
        }

        // push lock switch (button 1~5)
        private void leftOne_Click(object sender, EventArgs e)
        {
            if (0==leftButtonState[0]) // button is not pushed yet
            {
                // button pushed and locked
                //ready to fire
                leftButtonState[0] = 1;
                leftOne.Text = "Ready";
                return;

            }
            else if (1 == leftButtonState[0]) // button is pushed already
            {
                // release
                leftButtonState[0] = 0;
                leftOne.Text = "1";
                return;
            }       
        }

        private void leftTwo_Click(object sender, EventArgs e)
        {
            if (0 == leftButtonState[1]) // button is not pushed yet
            {
                // button pushed and locked
                // ready to fire
                leftButtonState[1] = 1;
                leftTwo.Text = "Ready";
                return;

            }
            else if (1 == leftButtonState[1]) // button is pushed already
            {
                // release
                leftButtonState[1] = 0; 
                leftTwo.Text = "2";
                return;
            }
        }

        private void leftThree_Click(object sender, EventArgs e)
        {
            if (0 == leftButtonState[2]) // button is not pushed yet
            {
                // button pushed and locked
                //ready to fire
                leftButtonState[2] = 1;
                leftThree.Text = "Ready";
                return;

            }
            else if (1 == leftButtonState[2]) // button is pushed already
            {
                // release
                leftButtonState[2] = 0;
                leftThree.Text = "3";
                return;
            }
        }

        private void leftFour_Click(object sender, EventArgs e)
        {
            if (0 == leftButtonState[3]) // button is not pushed yet
            {
                // button pushed and locked
                //ready to fire
                leftButtonState[3] = 1;
                leftFour.Text = "Ready";
                return;

            }
            else if (1 == leftButtonState[3]) // button is pushed already
            {
                // release
                leftButtonState[3] = 0;
                leftFour.Text = "4";
                return;
            }
        }

        private void leftFive_Click(object sender, EventArgs e)
        {
            if (0 == leftButtonState[4]) // button is not pushed yet
            {
                // button pushed and locked
                // ready to fire
                leftButtonState[4] = 1;
                leftFive.Text = "Ready";
                return;

            }
            else if (1 == leftButtonState[4]) // button is pushed already
            {
                // release
                leftButtonState[4] = 0;
                leftFive.Text = "5";
                return;
            }
        }

        // Final launch Button
        // Luanch all ready to fire bullets at once
        // toggle switch ( On or Off )
        private void leftOn_CheckedChanged(object sender, EventArgs e)
        {
            if (!isLeftOn)
            {
                isLeftOn = true;

                if (checkTrueBitEqulity(arr00000, leftButtonState)) PWM = 1000;
                else if (checkTrueBitEqulity(arr00001, leftButtonState)) PWM = 1015;
                else if (checkTrueBitEqulity(arr00010, leftButtonState)) PWM = 1030;
                else if (checkTrueBitEqulity(arr00011, leftButtonState)) PWM = 1045;
                else if (checkTrueBitEqulity(arr00100, leftButtonState)) PWM = 1060;
                else if (checkTrueBitEqulity(arr00101, leftButtonState)) PWM = 1075;
                else if (checkTrueBitEqulity(arr00110, leftButtonState)) PWM = 1090;
                else if (checkTrueBitEqulity(arr00111, leftButtonState)) PWM = 1105;
                else if (checkTrueBitEqulity(arr01000, leftButtonState)) PWM = 1120;
                else if (checkTrueBitEqulity(arr01001, leftButtonState)) PWM = 1135;

                else if (checkTrueBitEqulity(arr01010, leftButtonState)) PWM = 1150;
                else if (checkTrueBitEqulity(arr01011, leftButtonState)) PWM = 1165;
                else if (checkTrueBitEqulity(arr01100, leftButtonState)) PWM = 1180;
                else if (checkTrueBitEqulity(arr01101, leftButtonState)) PWM = 1195;
                else if (checkTrueBitEqulity(arr01110, leftButtonState)) PWM = 1210;
                else if (checkTrueBitEqulity(arr01111, leftButtonState)) PWM = 1225;
                else if (checkTrueBitEqulity(arr10000, leftButtonState)) PWM = 1240;
                else if (checkTrueBitEqulity(arr10001, leftButtonState)) PWM = 1255;
                else if (checkTrueBitEqulity(arr10010, leftButtonState)) PWM = 1270;
                else if (checkTrueBitEqulity(arr10011, leftButtonState)) PWM = 1285;

                else if (checkTrueBitEqulity(arr10100, leftButtonState)) PWM = 1300;
                else if (checkTrueBitEqulity(arr10101, leftButtonState)) PWM = 1315;
                else if (checkTrueBitEqulity(arr10110, leftButtonState)) PWM = 1330;
                else if (checkTrueBitEqulity(arr10111, leftButtonState)) PWM = 1345;
                else if (checkTrueBitEqulity(arr11000, leftButtonState)) PWM = 1360;
                else if (checkTrueBitEqulity(arr11001, leftButtonState)) PWM = 1375;
                else if (checkTrueBitEqulity(arr11010, leftButtonState)) PWM = 1390;
                else if (checkTrueBitEqulity(arr11011, leftButtonState)) PWM = 1405;
                else if (checkTrueBitEqulity(arr11100, leftButtonState)) PWM = 1420;
                else if (checkTrueBitEqulity(arr11101, leftButtonState)) PWM = 1435;

                else if (checkTrueBitEqulity(arr11110, leftButtonState)) PWM = 1450;
                else if (checkTrueBitEqulity(arr11111, leftButtonState))
                {
                    PWM = 1465;
                }
                sendPWMtoFC(PWM);

                buttonStateUpdate("After Left Side Launch");
                Thread.Sleep(1000);
                sendPWMtoFC(1000);
            }
        }

        // Reset after launch
        private void leftOff_CheckedChanged(object sender, EventArgs e)
        {
            if (isLeftOn)
            {
                isLeftOn = false;
                sendPWMtoFC(1000);
                buttonStateUpdate("After Left Side Reset");
            }
        }


        //----------------------- Right Side ---------------------
        // push return switch
        private void rightAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                if (0 == rightButtonState[i]) //button number -> ready
                {
                    rightButtonState[i] = 1;
                    if (0 == i) { rightOne.Text = "Ready"; }
                    if (1 == i) { rightTwo.Text = "Ready"; }
                    if (2 == i) { rightThree.Text = "Ready"; }
                    if (3 == i) { rightFour.Text = "Ready"; }
                    if (4 == i) { rightFive.Text = "Ready"; }
                }
            }
        }

        // push lock switch (button 1~5)
        private void rightOne_Click(object sender, EventArgs e)
        {
            if (0 == rightButtonState[0]) // button is not pushed yet
            {
                rightButtonState[0] = 1;
                rightOne.Text = "Ready";
            }
            else if (1 == rightButtonState[0]) // button is pushed already
            {
                rightButtonState[0] = 0;
                rightOne.Text = "1";
            }
        }

        private void rightTwo_Click(object sender, EventArgs e)
        {
            if (0 == rightButtonState[1]) // button is not pushed yet
            {
                rightButtonState[1] = 1;
                rightTwo.Text = "Ready";
            }
            else if (1 == rightButtonState[1]) // button is pushed already
            {
                rightButtonState[1] = 0;
                rightTwo.Text = "2";
            }
        }

        private void rightThree_Click(object sender, EventArgs e)
        {
            if (0 == rightButtonState[2]) // button is not pushed yet
            {
                rightButtonState[2] = 1;
                rightThree.Text = "Ready";
            }
            else if (1 == rightButtonState[2]) // button is pushed already
            {
                rightButtonState[2] = 0;
                rightThree.Text = "3";
            }
        }

        private void rightFour_Click(object sender, EventArgs e)
        {
            if (0 == rightButtonState[3]) // button is not pushed yet
            {
                rightButtonState[3] = 1;
                rightFour.Text = "Ready";
            }
            else if (1 == rightButtonState[3]) // button is pushed already
            {
                rightButtonState[3] = 0;
                rightFour.Text = "4";
            }
        }

        private void rightFive_Click(object sender, EventArgs e)
        {
            if (0 == rightButtonState[4]) // button is not pushed yet
            {
                rightButtonState[4] = 1;
                rightFive.Text = "Ready";
            }
            else if (1 == rightButtonState[4]) // button is pushed already
            {
                rightButtonState[4] = 0;
                rightFive.Text = "5";
            }
        }


        // Final launch Button
        // Luanch all ready to fire bullets at once
        // toggle switch (On or Off)
        private void rightOn_CheckedChanged(object sender, EventArgs e)
        {
            if (!isRightOn)
            {
                isRightOn = true;

                if (checkTrueBitEqulity(arr00000, rightButtonState)) PWM = 1500;
                else if (checkTrueBitEqulity(arr00001, rightButtonState)) PWM = 1515;//
                else if (checkTrueBitEqulity(arr00010, rightButtonState)) PWM = 1530;//
                else if (checkTrueBitEqulity(arr00011, rightButtonState)) PWM = 1545;//
                else if (checkTrueBitEqulity(arr00100, rightButtonState)) PWM = 1560;//
                else if (checkTrueBitEqulity(arr00101, rightButtonState)) PWM = 1575;//
                else if (checkTrueBitEqulity(arr00110, rightButtonState)) PWM = 1590;//
                else if (checkTrueBitEqulity(arr00111, rightButtonState)) PWM = 1605;//
                else if (checkTrueBitEqulity(arr01000, rightButtonState)) PWM = 1620;//
                else if (checkTrueBitEqulity(arr01001, rightButtonState)) PWM = 1635;

                else if (checkTrueBitEqulity(arr01010, rightButtonState)) PWM = 1650;
                else if (checkTrueBitEqulity(arr01011, rightButtonState)) PWM = 1665;
                else if (checkTrueBitEqulity(arr01100, rightButtonState)) PWM = 1680;
                else if (checkTrueBitEqulity(arr01101, rightButtonState)) PWM = 1695;
                else if (checkTrueBitEqulity(arr01110, rightButtonState)) PWM = 1710;
                else if (checkTrueBitEqulity(arr01111, rightButtonState)) PWM = 1725;
                else if (checkTrueBitEqulity(arr10000, rightButtonState)) PWM = 1740;
                else if (checkTrueBitEqulity(arr10001, rightButtonState)) PWM = 1755;
                else if (checkTrueBitEqulity(arr10010, rightButtonState)) PWM = 1770;
                else if (checkTrueBitEqulity(arr10011, rightButtonState)) PWM = 1785;

                else if (checkTrueBitEqulity(arr10100, rightButtonState)) PWM = 1800;
                else if (checkTrueBitEqulity(arr10101, rightButtonState)) PWM = 1815;
                else if (checkTrueBitEqulity(arr10110, rightButtonState)) PWM = 1830;//
                else if (checkTrueBitEqulity(arr10111, rightButtonState)) PWM = 1845;//
                else if (checkTrueBitEqulity(arr11000, rightButtonState)) PWM = 1860;//
                else if (checkTrueBitEqulity(arr11001, rightButtonState)) PWM = 1875;//
                else if (checkTrueBitEqulity(arr11010, rightButtonState)) PWM = 1890;//
                else if (checkTrueBitEqulity(arr11011, rightButtonState)) PWM = 1905;//
                else if (checkTrueBitEqulity(arr11100, rightButtonState)) PWM = 1920;//
                else if (checkTrueBitEqulity(arr11101, rightButtonState)) PWM = 1935;//

                else if (checkTrueBitEqulity(arr11110, rightButtonState)) PWM = 1950;//
                else if (checkTrueBitEqulity(arr11111, rightButtonState)) PWM = 1965;//
               // else PWM = 0;

                sendPWMtoFC(PWM);

                buttonStateUpdate("After Right Side Launch");
                Thread.Sleep(1000);
                sendPWMtoFC(1500);
            }
        }

        // Reset after launch
        private void rightOff_CheckedChanged(object sender, EventArgs e)
        {
            if (isRightOn)
            {
                isRightOn = false;
                sendPWMtoFC(1500);
                buttonStateUpdate("After Right Side Reset");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

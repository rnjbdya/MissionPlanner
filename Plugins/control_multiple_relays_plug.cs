using System;
using System.Windows.Forms;
using MissionPlanner;
using MissionPlanner.Plugin;
using MissionPlanner.Controls;

namespace PersistentSimpleActions
{
    public class ControlRelays : Plugin
    {
        private string _Name = "Control Multiple Relays";
        private string _Version = "0.1";
        private string _Author = "Ranjai Baidya";

        private controlMultipleRelays objSecondWindow;
        private bool isSecondWindowHide = true;


        public override string Name { get { return _Name; } }
        public override string Version { get { return _Version; } }
        public override string Author { get { return _Author; } }

        // CHANGE THIS TO TRUE TO USE THIS PLUGIN
        public override bool Init() { return true; }

        public override bool Loaded()
        {
            MyButton but_release1 = new MyButton();
            ToolTip toolTip1 = new ToolTip();

            but_release1.Text = "DEFENCE KOREA \nRecoilless Water gun";
            but_release1.Location = new System.Drawing.Point(4, 4);
            but_release1.Size = new System.Drawing.Size(150, 30);
            toolTip1.SetToolTip(but_release1, "Opens a new window with relay control buttons");
            but_release1.Click += new EventHandler(but1_release_Click);

            // Increase the minimum size of the persistent panel. Not necessary, but adds a little
            // more gap between the buttons and the tabs.
            MainV2.instance.FlightData.panel_persistent.MinimumSize = new System.Drawing.Size(0, 40);

            // Add the buttons
            MainV2.instance.FlightData.panel_persistent.Controls.Add(but_release1);

            objSecondWindow = new controlMultipleRelays();
            //           objSecondWindow.Show();
            //           isSecondWindowHide = false;

            return true;
        }

        public override bool Exit() { return true; }

        private void but1_release_Click(object sender, EventArgs e)
        {
            //	controlMultipleRelays objSecondWindow = new controlMultipleRelays();
            if (isSecondWindowHide)
            {
                objSecondWindow.Show();
                isSecondWindowHide = false;
            }
            else
            {
                objSecondWindow.Hide();
                isSecondWindowHide = true;
            }

        }

    }
}
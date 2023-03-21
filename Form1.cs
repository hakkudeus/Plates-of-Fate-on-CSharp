using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PlatesOfFate
{

    public partial class mainMenu : Form
    {

        public mainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cleanInterface();

            this.Text = "Plates of Fate -";
            infoText.Text = "[SYSTEM]: Game loaded successfully!"; // Shows up after cleaning all the stuff from prev.game

            playBtn.Enabled = true; // Now you can play.
            leaveBtn.Enabled = false; // But not leave. (jk. it just means you have not started the game).

        }

        // Loading timer separately.
        int sec = 10;
        int min = 4;
        string Timer2 = "";
        DateTime dt = new DateTime();

        // Setting up global variables and in-game settings.

        // General (Server)
        bool isSingleplayer = false;
        bool isMultiplayer = false;
        int serverSize = 0; // How many players are in-game.
        // Internal (Game)
        bool isRoundStarted = false;
        bool isDebugMode = false;
        bool isQueuedMode = false; // If the round type was bought.
        bool isInsaneMode = false; // Super Selection + Cursed Plates + Speed Rounds and possibly more...
        bool isClassicServer = true; // Default Server
        bool isVipServer = false; // Admin privs., but no progress and badges (just like debug mode).

        // Giving names and de-spawning plates.
        string player1 = "Player1";
        string player2 = "Player2";
        string player3 = "Player3";
        string player4 = "Player4";
        string player5 = "Player5";
        string player6 = "Player6";
        string player7 = "Player7";
        string player8 = "Player8";
        string player9 = "Player9";
        string player10 = "Player10";
        string player11 = "Player11";
        string player12 = "Player12";
        string player13 = "Player13";
        string player14 = "Player14";
        string player15 = "Player15";
        string player16 = "Player16";
        string player17 = "Player17";
        string player18 = "Player18";
        string player19 = "Player19";
        string player20 = "Player20";
        string player21 = "Player21";
        string player22 = "Player22";
        string player23 = "Player23";
        string player24 = "Player24";
        string player25 = "Player25";
        string player26 = "Player26";
        string player27 = "Player27";
        string player28 = "Player28";
        string player29 = "Player29";
        string player30 = "Player30";
        string player31 = "Player31";
        string player32 = "Player32";
        string player33 = "Player33";
        string player34 = "Player34";
        string player35 = "Player35";
        string player36 = "Player36";
        string player37 = "Player37";
        string player38 = "Player38";
        string player39 = "Player39";
        string player40 = "Player40";
        string player41 = "Player41";
        string player42 = "Player42";
        string player43 = "Player43";
        string player44 = "Player44";
        string player45 = "Player45";
        string player46 = "Player46";
        string player47 = "Player47";
        string player48 = "Player48";
        string player49 = "Player49";

        private void cleanInterface() // Runs before 1st round and after any round ends.
        {
            // Clearing up GUI.
            infoText.Text = "";
            playBtn.Enabled = false;
            leaveBtn.Enabled = false;
            helpTab.Visible = false;
            medalTab.Visible = false;
            debugTab.Visible = false;
            settingsTab.Visible = false;
            timerNum.Visible = false;

            // Moving text areas to original position
            helpTab.Location = new Point(10, 13);
            medalTab.Location = new Point(10, 13);
            debugTab.Location = new Point(10, 13);
            settingsTab.Location = new Point(10, 13);
            infoText.Location = new Point(7, 4);

            // Reseting inventory
            toolLogo1.Image = PlatesOfFate.Properties.Resources.tool_empty;
            toolLogo2.Image = PlatesOfFate.Properties.Resources.tool_empty;
            toolLogo3.Image = PlatesOfFate.Properties.Resources.tool_empty;
            toolLogo4.Image = PlatesOfFate.Properties.Resources.tool_empty;
            toolLogo5.Image = PlatesOfFate.Properties.Resources.tool_empty;
            toolLogo6.Image = PlatesOfFate.Properties.Resources.tool_empty;
            toolLogo7.Image = PlatesOfFate.Properties.Resources.tool_empty;
            toolLogo8.Image = PlatesOfFate.Properties.Resources.tool_empty;
            toolLogo9.Image = PlatesOfFate.Properties.Resources.tool_empty;
            toolBtn1.Text = "";
            toolBtn2.Text = "";
            toolBtn3.Text = "";
            toolBtn4.Text = "";
            toolBtn5.Text = "";
            toolBtn6.Text = "";
            toolBtn7.Text = "";
            toolBtn8.Text = "";
            toolBtn9.Text = "";

            plate1.Visible = false;
            plate1.Location = new Point(31, 29); 
            plate1.Size = new Size(55, 55);

            plate2.Visible = false;
            plate2.Location = new Point(115, 29);
            plate2.Size = new Size(55, 55);

            plate3.Visible = false;
            plate3.Location = new Point(196, 29);
            plate3.Size = new Size(55, 55);

            plate4.Visible = false;
            plate4.Location = new Point(277, 29);
            plate4.Size = new Size(55, 55);

            plate5.Visible = false;
            plate5.Location = new Point(362, 29);
            plate5.Size = new Size(55, 55);

            plate6.Visible = false;
            plate6.Location = new Point(444, 29);
            plate6.Size = new Size(55, 55);

            plate7.Visible = false;
            plate7.Location = new Point(530, 29);
            plate7.Size = new Size(55, 55);

            plate8.Visible = false;
            plate8.Location = new Point(31, 114);
            plate8.Size = new Size(55, 55);

            plate9.Visible = false;
            plate9.Location = new Point(115, 114);
            plate9.Size = new Size(55, 55);

            plate10.Visible = false;
            plate10.Location = new Point(196, 114);
            plate10.Size = new Size(55, 55);

            plate11.Visible = false;
            plate11.Location = new Point(277, 114);
            plate11.Size = new Size(55, 55);

            plate12.Visible = false;
            plate12.Location = new Point(362, 114);
            plate12.Size = new Size(55, 55);

            plate13.Visible = false;
            plate13.Location = new Point(444, 114);
            plate13.Size = new Size(55, 55);

            plate14.Visible = false;
            plate14.Location = new Point(530, 114);
            plate14.Size = new Size(55, 55);

            plate15.Visible = false;
            plate15.Location = new Point(31, 201);
            plate15.Size = new Size(55, 55);

            plate16.Visible = false;
            plate16.Location = new Point(115, 201);
            plate16.Size = new Size(55, 55);

            plate17.Visible = false;
            plate17.Location = new Point(196, 201);
            plate17.Size = new Size(55, 55);

            plate18.Visible = false;
            plate18.Location = new Point(277, 201);
            plate18.Size = new Size(55, 55);

            plate19.Visible = false;
            plate19.Location = new Point(362, 201);
            plate19.Size = new Size(55, 55);

            plate20.Visible = false;
            plate20.Location = new Point(444, 201);
            plate20.Size = new Size(55, 55);

            plate21.Visible = false;
            plate21.Location = new Point(530, 201);
            plate21.Size = new Size(55, 55);

            plate22.Visible = false;
            plate22.Location = new Point(31, 282);
            plate22.Size = new Size(55, 55);

            plate23.Visible = false;
            plate23.Location = new Point(115, 282);
            plate23.Size = new Size(55, 55);

            plate24.Visible = false;
            plate24.Location = new Point(196, 282);
            plate24.Size = new Size(55, 55);

            plate25.Visible = false;
            plate25.Location = new Point(277, 282);
            plate25.Size = new Size(55, 55);

            plate26.Visible = false;
            plate26.Location = new Point(362, 282);
            plate26.Size = new Size(55, 55);

            plate27.Visible = false;
            plate27.Location = new Point(444, 282);
            plate27.Size = new Size(55, 55);

            plate28.Visible = false;
            plate28.Location = new Point(530, 282);
            plate28.Size = new Size(55, 55);

            plate29.Visible = false;
            plate29.Location = new Point(31, 363);
            plate29.Size = new Size(55, 55);

            plate30.Visible = false;
            plate30.Location = new Point(115, 363);
            plate30.Size = new Size(55, 55);

            plate31.Visible = false;
            plate31.Location = new Point(196, 363);
            plate31.Size = new Size(55, 55);

            plate32.Visible = false;
            plate32.Location = new Point(277, 363);
            plate32.Size = new Size(55, 55);

            plate33.Visible = false;
            plate33.Location = new Point(362, 363);
            plate33.Size = new Size(55, 55);

            plate34.Visible = false;
            plate34.Location = new Point(444, 363);
            plate34.Size = new Size(55, 55);

            plate35.Visible = false;
            plate35.Location = new Point(530, 363);
            plate35.Size = new Size(55, 55);

            plate36.Visible = false;
            plate36.Location = new Point(31, 447);
            plate36.Size = new Size(55, 55);

            plate37.Visible = false;
            plate37.Location = new Point(115, 447);
            plate37.Size = new Size(55, 55);

            plate38.Visible = false;
            plate38.Location = new Point(196, 447);
            plate38.Size = new Size(55, 55);

            plate39.Visible = false;
            plate39.Location = new Point(277, 447);
            plate39.Size = new Size(55, 55);

            plate40.Visible = false;
            plate40.Location = new Point(362, 447);
            plate40.Size = new Size(55, 55);

            plate41.Visible = false;
            plate41.Location = new Point(444, 447);
            plate41.Size = new Size(55, 55);

            plate42.Visible = false;
            plate42.Location = new Point(530, 447);
            plate42.Size = new Size(55, 55);

            plate43.Visible = false;
            plate43.Location = new Point(31, 525);
            plate43.Size = new Size(55, 55);

            plate44.Visible = false;
            plate44.Location = new Point(115, 525);
            plate44.Size = new Size(55, 55);

            plate45.Visible = false;
            plate45.Location = new Point(196, 525);
            plate45.Size = new Size(55, 55);

            plate46.Visible = false;
            plate46.Location = new Point(277, 525);
            plate46.Size = new Size(55, 55);

            plate47.Visible = false;
            plate47.Location = new Point(362, 525);
            plate47.Size = new Size(55, 55);

            plate48.Visible = false;
            plate48.Location = new Point(444, 525);
            plate48.Size = new Size(55, 55);

            plate49.Visible = false;
            plate49.Location = new Point(530, 525);
            plate49.Size = new Size(55, 55);

            nextEventTimer.Interval = 100;
            nextEventTimer.Dispose();
            statsText.Text = "Stats will be available here during the game.";

            isRoundStarted = false;
        }

        private void showPlates()
        {
            plate1.Visible = true;
            plate2.Visible = true;
            plate3.Visible = true;
            plate4.Visible = true;
            plate5.Visible = true;
            plate6.Visible = true;
            plate7.Visible = true;
            plate8.Visible = true;
            plate9.Visible = true;
            plate10.Visible = true;
            plate11.Visible = true;
            plate12.Visible = true;
            plate13.Visible = true;
            plate14.Visible = true;
            plate15.Visible = true;
            plate16.Visible = true;
            plate17.Visible = true;
            plate18.Visible = true;
            plate19.Visible = true;
            plate20.Visible = true;
            plate21.Visible = true;
            plate22.Visible = true;
            plate23.Visible = true;
            plate24.Visible = true;
            plate25.Visible = true;
            plate26.Visible = true;
            plate27.Visible = true;
            plate28.Visible = true;
            plate29.Visible = true;
            plate30.Visible = true;
            plate31.Visible = true;
            plate32.Visible = true;
            plate33.Visible = true;
            plate34.Visible = true;
            plate35.Visible = true;
            plate36.Visible = true;
            plate37.Visible = true;
            plate38.Visible = true;
            plate39.Visible = true;
            plate40.Visible = true;
            plate41.Visible = true;
            plate42.Visible = true;
            plate43.Visible = true;
            plate44.Visible = true;
            plate45.Visible = true;
            plate46.Visible = true;
            plate47.Visible = true;
            plate48.Visible = true;
            plate49.Visible = true;
        }

        private void helpBtn_Click(object sender, EventArgs e) // Shows Hints
        {
            if (helpTab.Visible == false)
            {
                helpTab.BringToFront();
                infoText.Text = "This text line will inform you about current in-game events."; // Info-line Hint
                helpTab.Visible = true;
            }
            else
            {
                infoText.Text = "[SYSTEM]: Game loaded successfully!";
                helpTab.Visible = false;
            }

        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            gameStart();
        }

        private void leaveBtn_Click(object sender, EventArgs e)
        {
            gameStop();
            // reset point get during round
        }

        int sec1 = 6;
        string Timer3 = "";
        DateTime dt1 = new DateTime();

        private void roundBeginTimer_Tick(object sender, EventArgs e)
        {
            infoText.Location = new Point(325, 4);
            infoText.Text = "Round will begin in...";
            sec1--;
            Timer3 = dt1.AddSeconds(sec1).ToString("ss");
            timerNum.Text = Timer3;
            timerNum.Visible = true;
            timerVisual.Value = (timerVisual.Value - 15);
            if (sec1 == 0)
            {
                roundBeginTimer.Dispose();
                timerNum.Text = "0.0";
                timerNum.Visible = false;
                timerVisual.Value = 0;
                // EventTrigger();
            }
        }

        private void gameStart()  // Game started (Singleplayer)
        {
            timerVisual.Value = 100; 
            roundBeginTimer.Start(); // A

            infoText.Location = new Point(7, 4);
            playBtn.Enabled = false;
            leaveBtn.Enabled = true;
            isRoundStarted = true;
            showPlates();

            if (isSingleplayer == true)
            {
                // call another function that runs actual game and events

            }

            if (isMultiplayer == true)
            {
                // beta
            }
        }

        private void player0_LocationChanged(object sender, EventArgs e)
        {
            int plrX = player0.Location.X;
            int plrY = player0.Location.Y;
        }

        private void movePlr(object sender, KeyEventArgs e)
        {

        }

        private void gameStop()
        {
            cleanInterface();
            playBtn.Enabled = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (debugTab.Visible == false)
            {
                debugTab.BringToFront();
                debugTab.Visible = true;
            }
            else
            {
                debugTab.Visible = false;
            }
        }

        private void achBtn_Click(object sender, EventArgs e)
        {
            if (medalTab.Visible == false)
            {
                medalTab.BringToFront();
                medalTab.Visible = true;
            }
            else
            {
                medalTab.Visible = false;
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            this.Text = "Plates of Fate - Debug Mode";
            startDbgRnd.Enabled = false;
            debugMode1.Enabled = false;
            debugMode2.Enabled = false;
            isDebugMode = true;

            stopDbgRnd.Enabled = true;
            playBtn.Enabled = false;
            leaveBtn.Enabled = true;
        }

        public void NextEvent()
        {
            sec = 10;
            min = 4;
            timerVisual.Value = 100;

            nextEventTimer.Start();

        }

        private void button12_Click(object sender, EventArgs e) // A
        {
            NextEvent();
        }

        private void nextEventTimer_Tick(object sender, EventArgs e)
        {
            infoText.Location = new Point(325, 4);
            infoText.Text = "Next event will occur in:";
            sec--;
            timerNum.Visible = true;
            Timer2 = string.Format("{0}{1}", min, dt.AddSeconds(sec).ToString(".s"));
            timerNum.Text = Timer2;
            if (sec == 0)
            {
                min--;
                sec = 10;
                timerVisual.Value = (timerVisual.Value-20);
            }
            if (min == -1)
            {
                nextEventTimer.Dispose();
                timerNum.Text = "0.0";
                timerNum.Visible = false;
                timerVisual.Value = 0;
                infoText.Location = new Point(7, 4);
                EventTrigger();
            }
        }

        public void EventTrigger()
        {
            // This procedure will be executed when countdown = 0 and event n' player RNG is required.
            // aka This thing summons random event and/or chooses players.
        }

        private void stopDbgRnd_Click(object sender, EventArgs e)
        {
            this.Text = "Plates of Fate - "; // achtung
            stopDbgRnd.Enabled = false;

            startDbgRnd.Enabled = true;
            debugMode1.Enabled = true;
            debugMode2.Enabled = true;
            isDebugMode = false;

            playBtn.Enabled = true;
            leaveBtn.Enabled = false;
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

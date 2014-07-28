using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTP_Test_Harness
{
    public partial class mtpTestHarness : Form
    {
        bool connected;
        const String localdir = "";//location of what we are sending to the inst\
        String address = "";
        public mtpTestHarness()
        {
            InitializeComponent();
            connected = false;
        }

        private void connectB_Click(object sender, EventArgs e)
        {
            String input = addressTB.Text;
            //call conection here
            int resourceManager = 0, viError;
            int session = 0;
            viError = visa32.viOpenDefaultRM(out resourceManager);
            viError = visa32.viOpen(resourceManager, input,
                visa32.VI_NO_LOCK, visa32.VI_TMO_IMMEDIATE, out session);
            viError = visa32.viPrintf(session, "*IDN?\n");
            System.Text.StringBuilder idnString =
                new System.Text.StringBuilder(1000);
            viError = visa32.viScanf(session, "%1000t", idnString);
            System.Windows.Forms.MessageBox.Show(idnString.ToString());
            
            if (viError < visa32.VI_SUCCESS)
            {
                deviceLB.BackColor = Color.Red;
                deviceLB.Text = "Device Not Connected";
                connected = false;
                address = "";
            }
            else
            {
                deviceLB.BackColor = Color.Green;
                deviceLB.Text = "Device Connected";
                address = input;
                connected = true;
                addressTB.Enabled = false;
                //set default directory
                String cmd = "MMEM:CDIR '/User Files'";
                viError = visa32.viPrintf(session, cmd);
                //error check here               
                if (viError < visa32.VI_SUCCESS) { goto EndConnect; }
                viError = visa32.viPrintf(session, "SYST:ERR?\n");                
                System.Text.StringBuilder retString =
                    new System.Text.StringBuilder(1000);
                viError = visa32.viScanf(session, "%1000t", retString);
                System.Windows.Forms.MessageBox.Show(retString.ToString());
                
            }

            connectB.Enabled = !connected;
            disconnectB.Enabled = connected;

            visa32.viClose(session);
            visa32.viClose(resourceManager);
            return;

        EndConnect:
            System.Windows.Forms.MessageBox.Show("Unable to connect to device.");
            return;
        }

        private void disconnectB_Click(object sender, EventArgs e)
        {
            addressTB.Enabled = true;
            address = "";
            connectB.Enabled = true;
            disconnectB.Enabled = false;
        }

        private void test1B_Click(object sender, EventArgs e)
        {
            //send a file
            int ret = create_file("test");
            if (ret != 0)
            {
                //unable to send
            }
            else
            {
                //System.Windows.Forms.MessageBox.Show("WE DID IT!");
            }
        }

        private void test2B_Click(object sender, EventArgs e)
        {
            //create a empty folder
            //send a file
            int ret = create_folder("test");
            if (ret != 0)
            {
                //unable to send
            }
            else
            {
                //System.Windows.Forms.MessageBox.Show("WE DID IT!");
            }
        }

        

        private void test3B_Click(object sender, EventArgs e)
        {
            //send a folder full of files

        }

        private void test4B_Click(object sender, EventArgs e)
        {
            //send a folder with nested folders

        }

        private void launchB_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Program Files\\Agilent\\IO Libraries Suite\\AgilentConnectionExpert.exe");
        }

        private int create_file(String filename)
        {
            int resourceManager = 0, viError;
            int session = 0;
            viError = visa32.viOpenDefaultRM(out resourceManager);
            viError = visa32.viOpen(resourceManager, address,
                visa32.VI_NO_LOCK, visa32.VI_TMO_IMMEDIATE, out session);
            int nDigits = 20 , nBytes = 66;
            String cmd = "MMEM:DATA \""+filename+"\" ,#"+nDigits+nBytes;
            viError = visa32.viPrintf(session, cmd+"\n");
            
            if (viError < visa32.VI_SUCCESS)
            {
                System.Text.StringBuilder error =
                    new System.Text.StringBuilder(256);
                visa32.viStatusDesc(session, viError, error);
                System.Windows.Forms.MessageBox.Show(error.ToString());
                visa32.viClose(session);
                visa32.viClose(resourceManager);
                return 1;
            }
            viError = visa32.viPrintf(session, "SYST:ERR?\n");
            System.Text.StringBuilder idnString = new System.Text.StringBuilder(1000);
            viError = visa32.viScanf(session, "%1000s", idnString);
            System.Windows.Forms.MessageBox.Show(idnString.ToString());
            //check returned string
            char[] delimiters = {','};
            string[] text = idnString.ToString().Split(delimiters);
            int decVal = -1;
            try
            {
                decVal = Convert.ToInt32(text[0]);
            }
            catch (FormatException e)
            {

            }
            
            if (decVal < 0)
            {
                visa32.viClose(session);
                visa32.viClose(resourceManager);
                return 1;
            }
            else
            {
                visa32.viClose(session);
                visa32.viClose(resourceManager);
                return 0;
            }
                    
        }

        private int create_folder(string folderName)
        {
            int resourceManager = 0, viError;
            int session = 0;
            viError = visa32.viOpenDefaultRM(out resourceManager);
            viError = visa32.viOpen(resourceManager, address,
                visa32.VI_NO_LOCK, visa32.VI_TMO_IMMEDIATE, out session);
            
            String cmd = "MMEM:CDIR \"" + folderName + "\" ";
            viError = visa32.viPrintf(session, cmd + "\n");

            if (viError < visa32.VI_SUCCESS) //command sent correctly
            {
                System.Text.StringBuilder error =
                    new System.Text.StringBuilder(256);
                visa32.viStatusDesc(session, viError, error);
                System.Windows.Forms.MessageBox.Show(error.ToString());
                visa32.viClose(session);
                visa32.viClose(resourceManager);
                return 1;
            }
            viError = visa32.viPrintf(session, "SYST:ERR?\n");
            System.Text.StringBuilder idnString = new System.Text.StringBuilder(1000);
            viError = visa32.viScanf(session, "%1000s", idnString);
            System.Windows.Forms.MessageBox.Show(idnString.ToString());
            //check returned string
            char[] delimiters = { ',' };
            string[] text = idnString.ToString().Split(delimiters);
            int decVal = -1;
            try
            {
                decVal = Convert.ToInt32(text[0]);
            }
            catch (FormatException e)
            {

            }

            if (decVal < 0)
            {
                visa32.viClose(session);
                visa32.viClose(resourceManager);
                return 1;
            }
            else
            {
                visa32.viClose(session);
                visa32.viClose(resourceManager);
                return 0;
            }
            
        }
    }
}

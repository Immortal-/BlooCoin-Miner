using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Threading;
using System.Net.Sockets;
using System.IO;

namespace BlooCoin_Miner
{
    public partial class Miner : Form
    {
        public static int _Port = 3122;
        public static string _Ip = "server.bloocoin.org";
        public static  int MinerThreads;
        public static int diff = 7;
        public static string BLCAddr;
        public static long hashcount = 0;
        private int coinsfound = 0;
        public Thread Calc;
        public Thread[] MineThr;

        public Miner()
        {
            InitializeComponent();
        }

        private string HashIt(string text)
        {
            hashcount++;
            string shash = "";
            SHA512 alg = SHA512.Create();
            byte[] result = alg.ComputeHash(Encoding.UTF8.GetBytes(text));
            shash = Encoding.UTF8.GetString(result);
            return shash;
        }

        private string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random(Convert.ToInt32(hashcount));
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }

        private void MineMethod()
        {
            try
            {
                _Log("Thread started");
                while (true)
                {
                    string str = RandomString(5);
                    string hashish = HashIt(str);
                    if (hashish.StartsWith(String.Format("0000000")))
                    {
                        _Log("Found a coin!");
                        try
                        {
                            SubmitFind(hashish, str);
                            coinsfound++;
                            coins.Text = "Blc found: " + coinsfound;

                        }
                        catch { }
                    }
                }
            }
            catch { }
        }

        private void SubmitFind(string hashish, string str)
        {
            try
            {
                string msg = String.Format("{\"cmd\":\"check\" \",\"winning_string\":\"{0}\",\"winning_hash\":\"{1}\",\"addr\":\"{2}\"}", str, hashish, BLCAddr);
                TcpClient tcp = new TcpClient();
                tcp.Connect(_Ip, _Port);
                StreamWriter sw = new StreamWriter(tcp.GetStream());
                sw.WriteLine(msg);
                sw.Flush();
                sw.Close();
                tcp.Close();
                _Log("Coins Sent!");
            }
            catch{
                MessageBox.Show("Server is down please wait until it is back upagain!", "Server is down", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SpeedCalc()
        {
            while (true)
            {
                if (hashcount > 0)
                {
                    long tmpcnt = hashcount;
                    Thread.Sleep(1000);
                    long khs = (hashcount - tmpcnt) / 1000;
                    hashI.Text = "Kh/s: " + khs;
                }
            }
        }

        private void _Log(string message)
        {
            string myDate;
            myDate = DateTime.Now.ToString("MM/dd/yyyy");
            logScreen.Text += "[Miner] " + DateTime.Now.ToShortTimeString() + " | " + myDate + " | " + message + Environment.NewLine;
        }
       
        private void _Miner()
        {
            
                Calc = new Thread(new ThreadStart(SpeedCalc));
                Calc.Start();
                MineThr = new Thread[MinerThreads];
                _Log("Miner Started!");

                for (int i = 0; i < MinerThreads; i++)
                {
                    try
                    {
                        MineThr[i] = new Thread(new ThreadStart(MineMethod));
                        MineThr[i].Start();
                    }
                    catch(ThreadInterruptedException ex) {
                        MineThr[i].Abort();

                    }
                }
        }

        private void beginminer_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("You must provide a bloocoing address before mining!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                status.Text = "Status: Mining!";
                _Miner();
                beginminer.Enabled = false;
                endminer.Enabled = true;
            }
        }

        private void endminer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MinerThreads; i++)
            {
                MineThr[i].Abort();
            }
            _Log("Miner Stoped!");
            status.Text = "Status: waiting!";
            beginminer.Enabled = true;
            endminer.Enabled = false;
        }

        private void thamt_Scroll(object sender, EventArgs e)
        {
            MinerThreads = thamt.Value;
            tamt.Text = thamt.Value.ToString();
            threads.Text = "Threads: " + thamt.Value.ToString();
        }
    }
}

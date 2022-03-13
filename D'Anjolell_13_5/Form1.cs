using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace D_Anjolell_13_5
{
    public partial class Form1 : Form
    {
        //Richard D'Anjolell
        // List to hold te date data
        List<Dow> dowData = new List<Dow>();

        public Form1()
        {
            InitializeComponent();
        }

        // The LoadDowData method loads the data from the dow_prices.csv
        // file into the dowData list
        private void LoadDowData()
        {
            try
            {
                // Open the file with the dow price data
                StreamReader inputFile = File.OpenText("..\\..\\DJIA.csv");

                // Load the dow price data into a List of Dow objects
                while (!inputFile.EndOfStream)
                {
                    // Read a line from the file
                    string line = inputFile.ReadLine();

                    // Tokenize the line
                    string[] tokens = line.Split(',');

                    // Check the number of tokens
                    if (tokens.Length == 5)
                    {
                        // Create a Dow Object using the data from the file
                        Dow dow = new Dow()
                        {
                            Date = tokens[0],
                            Close = double.Parse(tokens[1]),
                            Open = double.Parse(tokens[2]),
                            High = double.Parse(tokens[3]),
                            Low = double.Parse(tokens[4])
                        };

                        // Add the Dow object to the dowData list
                        dowData.Add(dow);
                    }
                    else
                    {
                        MessageBox.Show("Bad Data Encountered in File.");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load the dow data into the dowData list
            LoadDowData();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            //Declare Variables
            List<double> closeValue = new List<double>();
            string dateValue;
            double findValue;

            // Create a Predicate to determine whether a number was greater than or equal to seached number
            Predicate<double> IsClose = delegate (double x)
            {
                bool isCloseNumber = false;

                if (x >= double.Parse(txtbxFirst.Text))
                {
                    isCloseNumber = true;
                }

                return isCloseNumber;
            };

            //Add closing values from csv to list
            foreach (Dow dow in dowData)
            {
                closeValue.Add(dow.Close);
            }

            //Find which closing value is equal to or greater than searched number
            findValue = closeValue.Find(IsClose);

            //Add date from csv that correlate with findValue closing value to list
            foreach (Dow dow in dowData)
            { 
                if (dow.Close == findValue)
                {
                    dateValue = dow.Date;
                    //Display date
                    lstbxDates.Items.Clear();
                    lstbxDates.Items.Add(dateValue);
                }
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            //Declare Variables
            List<double> closeValue = new List<double>();
            List<string> dateValue = new List<string>();
            List<double> findValue = new List<double>();

            // Create a Predicate to determine whether a number was greater than or equal to seached number
            Predicate<double> IsClose = delegate (double x)
            {
                bool isCloseNumber = false;

                if (x >= double.Parse(txtbxAll.Text))
                {
                    isCloseNumber = true;
                }

                return isCloseNumber;
            };

            //Add closing values from csv to list
            foreach (Dow dow in dowData)
            {
                closeValue.Add(dow.Close);
            }

            //Find which closing values are equal to or greater than searched number
            findValue = closeValue.FindAll(IsClose);

            //Add dates from csv that correlate with findValue closing values to list
            foreach (Dow dow in dowData)
            {
                for (int i = 0; i < findValue.Count; i++)
                {
                    if (dow.Close == findValue[i])
                    {
                        dateValue.Add(dow.Date);
                    }
                }
            }

            //Clear list box
            lstbxDates.Items.Clear();

            //Display all dates to listbox
            for (int i = 0; i < dateValue.Count; i++)
            {
                lstbxDates.Items.Add(dateValue[i]);
            }
        }
    }
}

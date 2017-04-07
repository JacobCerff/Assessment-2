using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterApp
    /* This program was written by Gail Mosdell
     * It forms the base of a converter program for the OS-Assessment Two for Cert IV
     * Date : February 2017
     * to do, change so its one button to convert all
     */
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        // Global Variables and Constants
        public double dbl_UofM, dbl_Convert;

        // Intializing the arrays for later use
        // by initializing outside of a function, allows all functions to use the array
        double[] measurement_Array = new double[5];

        // Convert button
        // displays all the results of each function
        private void btn_Covert_Click(object sender, EventArgs e)
        {
            // Convert Button Display
            // Centimeters to Inches Conversion Display
            lstBox.Items.Add("Centimeters to Inches:");
            lstBox.Items.Add(centimeters_To_Inches() + " inches.");
            lstBox.Items.Add("");

            // Meters to Feet Conversion Display
            lstBox.Items.Add("Meters to Feet:");
            lstBox.Items.Add(meters_To_Feet() + " feet.");
            lstBox.Items.Add("");

            // Centimeters to Feet Conversion Display
            lstBox.Items.Add("Centimeters to Feet:");
            lstBox.Items.Add(centimeters_To_Feet() + " feet.");
            lstBox.Items.Add("");

            // Kilometers to Miles Conversion Display
            lstBox.Items.Add("Kilometers to Miles:");
            lstBox.Items.Add(Kilometers_To_Miles() + " miles.");
            lstBox.Items.Add("");

            // Celsius to Fahrenheit Conversion Display
            lstBox.Items.Add("Celsius to Fahrenheit:");
            lstBox.Items.Add(celsius_To_Fahrenheit() + " °F.");
            lstBox.Items.Add("");
        }

        // Centimeters to Inches Function
        public double centimeters_To_Inches()
        {
            const double CM_TO_INCH = 0.3937;

            // constant variables for conversion algorithm
            if (!double.TryParse(txt_Cm_To_Inhces.Text, out measurement_Array[0]))
            {
                MessageBox.Show("Invalid input for Centimeters to Inches Convertion, Re-enter a valid integer.");
                txt_Cm_To_Inhces.Clear();
                txt_Cm_To_Inhces.Focus();
            }
            else
            {
                dbl_Convert = measurement_Array[0] * CM_TO_INCH;
            }

            return dbl_Convert;
        }

        // Meters to Feet Function
        public double meters_To_Feet()
        {
            const double M_TO_FEET = 0.3048;

            // 1m = 0.3048ft
            if (!double.TryParse(txt_Meters_To_Feet.Text, out measurement_Array[1]))
            {
                MessageBox.Show("Invalid input for Meters to Feet Convertion, Re-enter a valid integer.");
                txt_Meters_To_Feet.Clear();
                txt_Meters_To_Feet.Focus();
            }
            else
            {
                dbl_Convert = measurement_Array[1] * M_TO_FEET;
            }


            return dbl_Convert;
        }

        // Centimeters to Feet Function
        public double centimeters_To_Feet()
        {
            // constant variables for conversion algorithm
            // 1 cm = (1/30.48) ft = 0.0328084 ft
            const double CM_to_FT = 30.48;

            if (!double.TryParse(txt_Cm_To_Feet.Text, out measurement_Array[2]))
            {
                // If  a non numerical value was entered
                MessageBox.Show("Invalid input for Centimeters to Feet Convertion, Re-enter a valid integer.");
                txt_Cm_To_Feet.Clear();
                txt_Cm_To_Feet.Focus();
            }
            else
            {
                // Celsius to Fahrenheit Algorithm
                dbl_Convert = measurement_Array[2] / CM_to_FT;
            }

            return dbl_Convert;
        }

        // Kilometers to Miles Function
        public double Kilometers_To_Miles()
        {
            // constant variables for conversion algorithm
            // 1 km = (1km/1.609344) mi = 0.62137119;
            const double KM_to_MI = 1.609344;

            if (!double.TryParse(txt_Km_To_Miles.Text, out measurement_Array[3]))
            {
                // If  a non numerical value was entered
                MessageBox.Show("Invalid input for Kilometers to Miles Convertion, Re-enter a valid integer.");
                txt_Km_To_Miles.Clear();
                txt_Km_To_Miles.Focus();
            }
            else
            {
                // kilometers to miles Algorithm
                dbl_Convert = measurement_Array[3] * KM_to_MI;
            }

            return dbl_Convert;
        }

        // Celsius to Fahrenheit Function
        public double celsius_To_Fahrenheit()
        {
            // constant variables for conversion algorithm
            // 0 Cel = 32 Far
            const double C_to_F = 1.8;

            if (!double.TryParse(txt_Celsuis_To_Fahrenheit.Text, out measurement_Array[4]))
            {
                // If  a non numerical value was entered
                MessageBox.Show("Invalid input for Celsius To Fahrenheit Convertion, Re-enter a valid integer.");
                txt_Celsuis_To_Fahrenheit.Clear();
                txt_Celsuis_To_Fahrenheit.Focus();
            }
            else
            {
                // Celsius to Fahrenheit Algorithm
                dbl_Convert = (measurement_Array[4] * C_to_F) + 32;
            }

            return dbl_Convert;
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        // Clear Results button, clears all items from lstBox.Items
        private void btn_clr_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();
        }

    }
}  


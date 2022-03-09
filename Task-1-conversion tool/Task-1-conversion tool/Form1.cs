using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Made By Blake McCullough
//Discord - Spoiled_Kitten#4911
//Github - https://github.com/Blake-McCullough/
//Email - privblakemccullough@protonmail.com
//
//
//
//Alt + I == Inches to Centimetres
//Alt + F == Feet to Metres
//Alt + Y == Yards to Metres
//Alt + M == Miles to Kilometres
//
//
//
namespace Task_1_conversion_tool
{


    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent(); 
        }
        public void generateresult(ref int c, ref int d)
        { }
            public void showitems()
        {
            //Shows items when called for results
            result.Visible = true;
            FirstOption.Visible = true;
            SecondOption.Visible = true;
            equals.Visible = true;
        }








        private void inchestocm_Click(object sender, EventArgs e)
        { //Sets the label to correct names
            FirstOption.Text = "Inches";
            SecondOption.Text = "Centimetres";
            //Sets conversion rate
            double conversionrate = 2.54;
            //Gets value from text box
            var sourceValue = textBox1.Text;
            //setsup variables
     
            double doubleValue;
            double convertedresult;
            //Checks if user had entered a value, and if not alerts them
            if (sourceValue == "") { MessageBox.Show("Hey, we need an input to work with over here."); }
            else

            {//Trys to parse value to double, if value cannot be parsed, E.G. is a string, then will alert user, otherwise calculates result.
                if (double.TryParse(sourceValue, out doubleValue))
                {//Checks if value is negative, and if it is, then lets user know.
                    if (doubleValue < 0) { MessageBox.Show("Hey, we need an positive number over here. \nNot:" + doubleValue); }
                    else
                    {
                        //Calculating result
                        convertedresult = doubleValue * conversionrate;
                        //Sets the output boxes value to the converted rate (To 6 decimal places)
                        this.result.Text = convertedresult.ToString("0.######"); ;
                        //Shows the items
                        showitems();
                    }
                }
                else
                {
                    //Tells user needs a number, not a string, and lets them know there input
                    MessageBox.Show("Hey, we need an number over here. \nNot:" + sourceValue);

                }
            }
        }
        private void feettom_Click(object sender, EventArgs e)
        {
            //Sets the label to correct names
            FirstOption.Text = "Feet";
            SecondOption.Text = "Metres";
            //Sets conversion rate
            double conversionrate = 0.3048;
            //Gets value from text box
            var sourceValue = textBox1.Text;
            //setsup variables
            double doubleValue;
            double convertedresult;
            //Checks if user had entered a value, and if not alerts them
            if (sourceValue == "") { MessageBox.Show("Hey, we need an input to work with over here."); }
            else

            {//Trys to parse value to double, if value cannot be parsed, E.G. is a string, then will alert user, otherwise calculates result.
                if (double.TryParse(sourceValue, out doubleValue))
                {//Checks if value is negative, and if it is, then lets user know.
                    if (doubleValue < 0) { MessageBox.Show("Hey, we need an positive number over here. \nNot:" + doubleValue); }
                    else
                    {
                        //Calculating result
                        convertedresult = doubleValue * conversionrate;
                        //Sets the output boxes value to the converted rate (To 6 decimal places)
                        this.result.Text = convertedresult.ToString("0.######"); ;
                        //Shows the items
                        showitems();
                    }
                }
                else
                {
                    //Tells user needs a number, not a string, and lets them know there input
                    MessageBox.Show("Hey, we need an number over here. \nNot:" + sourceValue);

                }
            }

        }
        private void yardstom_Click(object sender, EventArgs e)
        { //Sets the label to correct names
            FirstOption.Text = "Yards";
            SecondOption.Text = "Metres";
            //Sets Conversion rate
            double conversionrate = 0.9144;
            //Gets value from text box
            var sourceValue = textBox1.Text;
            //setsup variables
            double doubleValue;
            double convertedresult;
            //Checks if user had entered a value, and if not alerts them
            if (sourceValue == "") { MessageBox.Show("Hey, we need an input to work with over here."); }
            else

            {//Trys to parse value to double, if value cannot be parsed, E.G. is a string, then will alert user, otherwise calculates result.
                if (double.TryParse(sourceValue, out doubleValue))
                {//Checks if value is negative, and if it is, then lets user know.
                    if (doubleValue < 0) { MessageBox.Show("Hey, we need an positive number over here. \nNot:" + doubleValue); }
                    else
                    {
                        //Calculating result
                        convertedresult = doubleValue * conversionrate;
                        //Sets the output boxes value to the converted rate (To 6 decimal places)
                        this.result.Text = convertedresult.ToString("0.######"); ;
                        //Shows the items
                        showitems();
                    }
                }
                else
                {
                    //Tells user needs a number, not a string, and lets them know there input
                    MessageBox.Show("Hey, we need an number over here. \nNot:" + sourceValue);

                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Sets the label to correct names
            FirstOption.Text = "Miles";
            SecondOption.Text = "Kilometres";
            //Sets conversion rate
            double conversionrate = 1.609;

            //Gets value from text box
            var sourceValue = textBox1.Text;
            //setsup variables
            double doubleValue;
            double convertedresult;
            //Checks if user had entered a value, and if not alerts them
            if (sourceValue == "") { MessageBox.Show("Hey, we need an input to work with over here."); }
            else
            
            {//Trys to parse value to double, if value cannot be parsed, E.G. is a string, then will alert user, otherwise calculates result.
                if (double.TryParse(sourceValue, out doubleValue))
                {//Checks if value is negative, and if it is, then lets user know.
                    if (doubleValue < 0) { MessageBox.Show("Hey, we need an positive number over here. \nNot:" + doubleValue); }
                    else
                    {
                        //Calculating result
                        convertedresult = doubleValue * conversionrate;
                        //Sets the output boxes value to the converted rate (To 6 decimal places)
                        this.result.Text = convertedresult.ToString("0.######"); ;
                        //Shows the items
                        showitems();
                    }
                }
                else
                {
                    //Tells user needs a number, not a string, and lets them know there input
                    MessageBox.Show("Hey, we need an number over here. \nNot:" + sourceValue);

                }
            }

        }


        //Checks if the exit button has been clicked, and if it has closes the application
        private void button1_Click(object sender, EventArgs e)
        {//Closes form
            this.Close();
        }


        private void KeyDownForExit(object sender, KeyEventArgs e)
        {   //checks if is escape key
            if (e.KeyCode == Keys.Escape)
            {//Closes form
                this.Close();
            }
            //Checks for alt key being pressed as well as I, then does Inches conversion
            if (e.Alt && e.KeyData == (Keys.I | Keys.Alt))
            {
                //Sets the label to correct names
                FirstOption.Text = "Inches";
                SecondOption.Text = "Centimetres";
                //Sets conversion rate
                double conversionrate = 2.54;
                //Gets value from text box
                var sourceValue = textBox1.Text;
                //setsup variables

                double doubleValue;
                double convertedresult;
                //Checks if user had entered a value, and if not alerts them
                if (sourceValue == "") { MessageBox.Show("Hey, we need an input to work with over here."); }
                else

                {//Trys to parse value to double, if value cannot be parsed, E.G. is a string, then will alert user, otherwise calculates result.
                    if (double.TryParse(sourceValue, out doubleValue))
                    {//Checks if value is negative, and if it is, then lets user know.
                        if (doubleValue < 0) { MessageBox.Show("Hey, we need an positive number over here. \nNot:" + doubleValue); }
                        else
                        {
                            //Calculating result
                            convertedresult = doubleValue * conversionrate;
                            //Sets the output boxes value to the converted rate (To 6 decimal places)
                            this.result.Text = convertedresult.ToString("0.######"); ;
                            //Shows the items
                            showitems();
                        }
                    }
                    else
                    {
                        //Tells user needs a number, not a string, and lets them know there input
                        MessageBox.Show("Hey, we need an number over here. \nNot:" + sourceValue);

                    }
                }
            }
            //Checks for alt key being pressed as well as F, then does Feet conversion
            if (e.Alt && e.KeyData == (Keys.F | Keys.Alt))
            {
                //Sets the label to correct names
                FirstOption.Text = "Feet";
                SecondOption.Text = "Metres";
                //Sets conversion rate
                double conversionrate = 0.3048;
                //Gets value from text box
                var sourceValue = textBox1.Text;
                //setsup variables
                double doubleValue;
                double convertedresult;
                //Checks if user had entered a value, and if not alerts them
                if (sourceValue == "") { MessageBox.Show("Hey, we need an input to work with over here."); }
                else

                {//Trys to parse value to double, if value cannot be parsed, E.G. is a string, then will alert user, otherwise calculates result.
                    if (double.TryParse(sourceValue, out doubleValue))
                    {//Checks if value is negative, and if it is, then lets user know.
                        if (doubleValue < 0) { MessageBox.Show("Hey, we need an positive number over here. \nNot:" + doubleValue); }
                        else
                        {
                            //Calculating result
                            convertedresult = doubleValue * conversionrate;
                            //Sets the output boxes value to the converted rate (To 6 decimal places)
                            this.result.Text = convertedresult.ToString("0.######"); ;
                            //Shows the items
                            showitems();
                        }
                    }
                    else
                    {
                        //Tells user needs a number, not a string, and lets them know there input
                        MessageBox.Show("Hey, we need an number over here. \nNot:" + sourceValue);

                    }
                }

            }
            //Checks for alt key being pressed as well as Y, then does Yards conversion
            if (e.Alt && e.KeyData == (Keys.Y | Keys.Alt))
            {
                //Sets the label to correct names
                FirstOption.Text = "Yards";
                SecondOption.Text = "Metres";
                //Sets Conversion rate
                double conversionrate = 0.9144;
                //Gets value from text box
                var sourceValue = textBox1.Text;
                //setsup variables
                double doubleValue;
                double convertedresult;
                //Checks if user had entered a value, and if not alerts them
                if (sourceValue == "") { MessageBox.Show("Hey, we need an input to work with over here."); }
                else

                {//Trys to parse value to double, if value cannot be parsed, E.G. is a string, then will alert user, otherwise calculates result.
                    if (double.TryParse(sourceValue, out doubleValue))
                    {//Checks if value is negative, and if it is, then lets user know.
                        if (doubleValue < 0) { MessageBox.Show("Hey, we need an positive number over here. \nNot:" + doubleValue); }
                        else
                        {
                            //Calculating result
                            convertedresult = doubleValue * conversionrate;
                            //Sets the output boxes value to the converted rate (To 6 decimal places)
                            this.result.Text = convertedresult.ToString("0.######"); ;
                            //Shows the items
                            showitems();
                        }
                    }
                    else
                    {
                        //Tells user needs a number, not a string, and lets them know there input
                        MessageBox.Show("Hey, we need an number over here. \nNot:" + sourceValue);

                    }
                }


            }
            //Checks for alt key being pressed as well as M, then does Miles conversion
            if (e.Alt&& e.KeyData == (Keys.M | Keys.Alt))
            { //Sets the label to correct names
                FirstOption.Text = "Miles";
                SecondOption.Text = "Kilometres";
                //Sets conversion rate
                double conversionrate = 1.609;

                //Gets value from text box
                var sourceValue = textBox1.Text;
                //setsup variables
                double doubleValue;
                double convertedresult;
                //Checks if user had entered a value, and if not alerts them
                if (sourceValue == "") { MessageBox.Show("Hey, we need an input to work with over here."); }
                else

                {//Trys to parse value to double, if value cannot be parsed, E.G. is a string, then will alert user, otherwise calculates result.
                    if (double.TryParse(sourceValue, out doubleValue))
                    {//Checks if value is negative, and if it is, then lets user know.
                        if (doubleValue < 0) { MessageBox.Show("Hey, we need an positive number over here. \nNot:" + doubleValue); }
                        else
                        {
                            //Calculating result
                            convertedresult = doubleValue * conversionrate;
                            //Sets the output boxes value to the converted rate (To 6 decimal places)
                            this.result.Text = convertedresult.ToString("0.######"); ;
                            //Shows the items
                            showitems();
                        }
                    }
                    else
                    {
                        //Tells user needs a number, not a string, and lets them know there input
                        MessageBox.Show("Hey, we need an number over here. \nNot:" + sourceValue);

                    }
                }
            }
        }


    }
}

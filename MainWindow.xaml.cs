using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace painterProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void nameInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string name;                                                            // sets name as string
            string text = "-SUMMARY- \n";                                          
            name = nameInput.Text;                                                  // sets name from user input
            text = text + "Name:      " + name + "\n";                              // adds to text to be output

            string addr;                                                            // sets address as string
            addr = addressInput.Text;                                               // sets address from user input   
            text = text + "Address:   " + addr + "\n";                              // adds to text to be output

            string mail;                                                            // sets email as string
            mail = emailInput.Text;                                                 // sets email from user input
            text = text + "Email:      " + mail + "\n";                             // adds to text to be output


            bool decision;                                                          // sets decision as bool value
            decision = true;                                                        // sets as true
            

            string text2;                                                           // sets text2 as string 
            string text3;                                                           // sets text3 as string
            // sets values as integers
            int len1;                                                               
            int len2;
            int len3;
            int len4;
            int h1;


            // trys to convert user input to data, outputs true/false depending if successful
            bool length1 = int.TryParse(len1Input.Text, out len1); 
            bool length2 = int.TryParse(len2Input.Text, out len2);
            bool length3 = int.TryParse(len3Input.Text, out len3);
            bool length4 = int.TryParse(len4Input.Text, out len4);
            bool height1 = int.TryParse(heightInput.Text, out h1);




            if(length1)                                         // if length 1 convert to int successful/ 'true'
            {
                text2 = " ";                                    
                if (len1 >= 1 && len1 <= 25)                    // if length 1 between values 1 and 25 sets text2 (error output) to null
                {
                    text2 = " ";
                }
                else
                {
                    decision = false;                                       // decision is false
                    text2 = "Error - Enter lengths between 1 and 25";       // outputs error to user if not in bounds
                    errorDetail.Text = text2;                                           
                    outputBox.Clear();                                      // clears summary box so no data is shown 
                }
            }
            else
            {
                decision = false;                                   // decision is false
                text2 = "Error - Enter length 1";                  // if int convert unsuccessful no integer is entered
                errorDetail.Text = text2;                          // tells user to enter valid integer
                outputBox.Clear();                                 // clears summary box so no data is shown 
            }


            if (length2)               // if length 2 convert to int successful/ 'true'
            {
                text2 = " ";
                if (1 <= len2 && len2 <= 25)             // if length 2 between values 1 and 25 sets text2 (error output) to null
                {
                    text2 = " ";
                }
                else
                {
                    decision = false;                                    // decision is false
                    text2 = "Error - Enter lengths between 1 and 25";    // outputs error to user if not in bounds
                    errorDetail.Text = text2;               
                    outputBox.Clear();                                   // clears summary box so no data is shown

                }
            }
            else
            {
                decision = false;                                        // decision is false
                text2 = "Error - Enter length 2";                        // if int convert unsuccessful no integer is entered
                errorDetail.Text = text2;                               // tells user to enter valid integer
                outputBox.Clear();                                      // clears summary box so no data is shown
            }



            if (length3)                // if length 3 convert to int successful/ 'true'
            {
                text2 = " ";
                if (1 <= len3 && len3 <= 25)        // if length 3 between values 1 and 25 sets text2 (error output) to null
                {
                    text2 = " ";
                }
                else
                {
                    decision = false;                                       // decision is false
                    text2 = "Error - Enter lengths between 1 and 25";        // outputs error to user if not in bounds
                    errorDetail.Text = text2;                               
                    outputBox.Clear();                                      // clears summary box so no data is shown
                }
            }
            else
            {
                decision = false;                                   // decision is false
                text2 = "Error - Enter length 3";                   // if int convert unsuccessful no integer is entered
                errorDetail.Text = text2;                           // tells user to enter valid integer
                outputBox.Clear();                                  // clears summary box so no data is shown
            }


            if (length4)                // if length 4 convert to int successful/ 'true'
            {
                text2 = " ";
                if (1 <= len4 && len4 <= 25)        // if length 4 between values 1 and 25 sets text2 (error output) to null
                {
                    text2 = " ";
                }
                else
                {
                    decision = false;                                       // decision is false
                    text2 = "Error - Enter lengths between 1 and 25";        // outputs error to user if not in bounds
                    errorDetail.Text = text2;
                    outputBox.Clear();                                      // clears summary box so no data is shown
                }
            }
            else
            {
                decision = false;                                   // decision is false
                text2 = "Error - Enter length 4";                   // if int convert unsuccessful no integer is entered
                errorDetail.Text = text2;                           // tells user to enter valid integer
                outputBox.Clear();                                  // clears summary box so no data is shown
            }



            if (height1)                                            // if height convert to int successful/ 'true'
            {
                text2 = " ";
                if (h1 >= 2 && h1 <= 6)                         // if height between values 1 and 25 sets text2 (error output) to null
                {
                    text2 = " ";
                }
                else
                {
                    decision = false;                                       // decision is false
                    text2 = "Error - Enter height between 2 and 6";         // outputs error to user if not in bounds
                    errorDetail.Text = text2;
                    outputBox.Clear();                                      // clears summary box so no data is shown
                }
            }
            else
            {
                decision = false;                                         // decision is false 
                text2 = "Error - Enter height";                           // if height int convert unsuccessful no integer is entered
                errorDetail.Text = text2;                                 // tells user to enter valid integer
                outputBox.Clear();                                        // clears summary box so no data is shown
            }

            double total = 0;                                             // sets total as double (floating point number)

            int calc = len1 + len2 + len3 + len4;                           // adds all lengths
            int times = calc * h1;                                          // calculates area by multiplying height and total lenght
            text = text + "Room Area:       " + times + "M² \n";           // adds room areas to text to be output
            
            if (times < 8)                                // if mutiplication is les than 8- it indicates not all numbers are entered with the ranges needed
            {
                decision = false;                          // decision becomes false
            }


            if ((bool)RB1.IsChecked)                    // checks if radiobutton 1 (eco paint) is checked
            {
                errorTypes.Clear();                                         // if selected, clears error output box from previous errors
                double ecoCalc = 0.45 * times;                              // calculates price
                text = text + "Economy Paint    + £" + ecoCalc + "\n";      // adds to text to be output with price
                total = ecoCalc;                                            // added to the total 
            }
            else if ((bool)RB2.IsChecked)               // checks if radiobutton 2 (standard paint) is checked
            {
                errorTypes.Clear();                         // if selected, clears error output box from previous errors
                double stCalc = 1 * times;                                          // calculates price
                text = text + "Standard Paint   + £" + stCalc + "\n";               // adds to text ot be output with price
                total = stCalc;                                                     // added to total 
            }
            else if ((bool)RB3.IsChecked)                       // checks if radiobutton 1 (eco paint) is checked
            {
                errorTypes.Clear();                                               // if selected, clears error output box from previous errors
                double premiumCalculation = 1.75 * times;                         // calculates price
                text = text + "Premium Paint   + £" + premiumCalculation + "\n";  // adds to text to be output with price
                total = premiumCalculation;                                       // added to total 
            }
            else                                                               // if none selected
            {
                outputBox.Clear();                                          // clears summary box so no data is shown
                text3 = "Select Paint Type";                                // error message to user
                errorTypes.Text = text3;                                    // outputs to user
            }

            double undercalc = times * 0.5;                                // calculation for undercoat
                
            if ((bool)undercoatCheck.IsChecked)           // if undercoat box is checked adds to text to be output / adds calculation to total
            {
                text = text + "Undercoat: YES  + £" + undercalc + "\n";            
                total = total + undercalc;
            } else                                           // if nt checked outputs no price change
            {
                text = text + "Undercoat: NO  + £0\n";
            }

            

            if (decision == true)                                       // decision if all needed areas completed
            {
                text = text + "--------------------------------------------------------------------" + "\n";  // adds seperator to text
                text = text + "TOTAL:                 £" + total;           // adds to total to text 
                outputBox.Text = text;                                      // outputs all text and summary to textbox
                errorDetail.Clear();                                        // clears all errors 
                errorTypes.Clear();                                         // clears all errors
            }
            else
            {
                outputBox.Clear();                                      // if not all conditions met, does not output to user any sections
            }







        }
    }
}

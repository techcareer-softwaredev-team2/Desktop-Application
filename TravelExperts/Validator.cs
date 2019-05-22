using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts
{
    //a collection method
    //every method assumes that the controls have Tag property set
    public static class Validator
    {
        //checks if text box is not empty
        public static bool IsPresent(TextBox tb)
        {
            bool result = true; //innocent until proven guilty

            if (tb.Text == "")
            {
                MessageBox.Show(tb.Tag + " has to be provided",
                                "Input Error");
                result = false; //guilty
                tb.Focus();
            }
            return result;
        }

        //checks if input in a text box is an integer
        public static bool IsInteger(TextBox tb)
        {
            bool result = true; //again, innocent until proven guilty
            int parsedValue;

            if (!Int32.TryParse(tb.Text, out parsedValue))
            {
                MessageBox.Show(tb.Tag + " has to be a whole number",
                                "Input Error");
                result = false;
                tb.SelectAll();
                tb.Focus();
            }
            return result;
        }

        //checks if input in a text box is a double
        public static bool IsDouble(TextBox tb)
        {
            bool result = true; //again, innocent until proven guilty
            double parsedValue;

            if (!Double.TryParse(tb.Text, out parsedValue))
            {
                MessageBox.Show(tb.Tag + " has to be a whole number",
                                "Input Error");
                result = false;
                tb.SelectAll();
                tb.Focus();
            }
            return result;
        }

        //checks if input in a text box is a non-negative int
        public static bool IsNonNegInteger(TextBox tb)
        {
            bool result = true; //again, innocent until proven guilty
            int parsedValue = Int32.Parse(tb.Text); //we know that it is an integer

            if (parsedValue < 0)
            {
                MessageBox.Show(tb.Tag + " has to be positive or zero",
                                "Input Error");
                result = false;
                tb.SelectAll();
                tb.Focus();
            }
            return result;
        }

        //checks if input in a text box is a non-negative double
        public static bool IsNonNegDouble(TextBox tb)
        {
            bool result = true; //again, innocent until proven guilty
            double parsedValue = Double.Parse(tb.Text); //we know that it is a double

            if (parsedValue < 0)
            {
                MessageBox.Show(tb.Tag + " has to be positive or zero",
                                "Input Error");
                result = false;
                tb.SelectAll();
                tb.Focus();
            }
            return result;
        }

        //checks if input in a text box is a decimal
        public static bool IsDecimal(TextBox tb)
        {
            bool result = true; //again, innocent until proven guilty
            decimal parsedValue;

            if (!Decimal.TryParse(tb.Text, out parsedValue))
            {
                MessageBox.Show(tb.Tag + " has to be a whole number",
                                "Input Error");
                result = false;
                tb.SelectAll();
                tb.Focus();
            }
            return result;
        }


        public static bool IsDecimalInRange(TextBox tb, decimal minValue, decimal maxValue)
        {
            bool result = true; //again, innocent until proven guilty
            decimal parsedValue = Decimal.Parse(tb.Text); //we know that it is a decimal

            if (parsedValue < minValue || parsedValue > maxValue)
            {
                MessageBox.Show(tb.Tag + " has to be between " + minValue.ToString() + " and " + maxValue.ToString() + "Input Error");
                result = false;
                tb.SelectAll();
                tb.Focus();
            }
            return result;
        }
    }
}

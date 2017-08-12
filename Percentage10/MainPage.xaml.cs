using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.System.Profile;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Percentage10
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        bool WindowsMobile;
        public MainPage()
        {
            WindowsMobile = AnalyticsInfo.VersionInfo.DeviceFamily.Equals("Windows.Mobile");
            this.InitializeComponent();

            bool IsHardwareButtonAPIPresent = Windows.Foundation.Metadata.ApiInformation.IsTypePresent("Windows.Phone.UI.Input.HardwareButtons");
            if (IsHardwareButtonAPIPresent)
            {
                //Windows.Phone.UI.Input.HardwareButtons.BackPressed += HardwareButtons_BackPressed;
            }
        }

        /*private void HardwareButtons_BackPressed(object sender, Windows.Phone.UI.Input.BackPressedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
                e.Handled = true;
            }
        }*/

        bool percentage = true;
        bool dec = false;
        bool FirstDigit = true;
        bool returning = false;
        decimal FirstDecimal;
        string FirstDecimalHolder;
        string FirstTotal;
        string FirstHolder;
        int First;

        decimal SecondDecimal;
        string SecondDecimalHolder;
        string SecondTotal;
        string SecondHolder;
        int Second;

        int SecondDecimalTempLength;
        decimal SecondDecimalWorking;
        int SecondDecimalLength;

        int FirstDecimalTempLength;
        decimal FirstDecimalWorking;
        int FirstDecimalLength;

        string Holder;
        decimal Answer;

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void btn_Home_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void btn_Help_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(About));
        }

        private void btn_Contact_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Contact));
        }

        private void More_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(More));
        }

        private string EnteringNumbers(int Number)
        {
            if (percentage)
            {
                if (dec)
                {
                    if (FirstDigit)
                    {
                        FirstDecimal = Number;
                        FirstDigit = false;
                    }
                    else
                    {
                        FirstDecimal = FirstDecimal * 10 + Number;
                    }
                    FirstDecimalHolder = FirstDecimal.ToString();
                    DecimalWorking();
                    FirstTotal = FirstHolder + "." + FirstDecimalHolder;
                    return FirstTotal;
                }
                else
                {
                    if (FirstDigit)
                    {
                        First = Number;
                        FirstDigit = false;
                    }
                    else
                    {
                        First = First * 10 + Number;
                    }
                    FirstHolder = First.ToString();
                    return FirstHolder;
                }
            }
            else
            {
                if (dec)
                {
                    if (FirstDigit)
                    {
                        SecondDecimal = Number;
                        FirstDigit = false;
                    }
                    else
                    {
                        SecondDecimal = SecondDecimal * 10 + Number;
                    }
                    SecondDecimalHolder = SecondDecimal.ToString();
                    DecimalWorking();
                    SecondTotal = SecondHolder + "." + SecondDecimalHolder;
                    return SecondTotal;
                }
                else
                {
                    if (FirstDigit)
                    {
                        Second = Number;
                        FirstDigit = false;
                    }
                    else
                    {
                        Second = Second * 10 + Number;
                    }
                    SecondHolder = Second.ToString();
                    return SecondHolder;
                }
            }
        }
        private void DecimalWorking()
        {
            if (!percentage)
            {
                SecondDecimalTempLength = SecondDecimalHolder.Length;
                SecondDecimalWorking = Convert.ToDecimal(SecondDecimalHolder);
                SecondDecimalLength = 1;
                for (int i = 0; i < SecondDecimalTempLength; i++)
                {
                    SecondDecimalLength = SecondDecimalLength * 10;
                }
                SecondDecimalWorking = SecondDecimalWorking / SecondDecimalLength;
            }
            FirstDecimalTempLength = FirstDecimalHolder.Length;
            FirstDecimalWorking = Convert.ToDecimal(FirstDecimalHolder);
            FirstDecimalLength = 1;
            for (int i = 0; i < FirstDecimalTempLength; i++)
            {
                FirstDecimalLength = FirstDecimalLength * 10;
            }
            FirstDecimalWorking = FirstDecimalWorking / FirstDecimalLength;
        }
        private void btn_one_Click(object sender, RoutedEventArgs e)
        {
            Holder = EnteringNumbers(1);
            txt_answer.Text = Holder;
            returning = false;
        }

        private void btn_two_Click(object sender, RoutedEventArgs e)
        {
            Holder = EnteringNumbers(2);
            txt_answer.Text = Holder;
            returning = false;
        }

        private void btn_three_Click(object sender, RoutedEventArgs e)
        {
            Holder = EnteringNumbers(3);
            txt_answer.Text = Holder;
            returning = false;
        }

        private void btn_four_Click(object sender, RoutedEventArgs e)
        {
            Holder = EnteringNumbers(4);
            txt_answer.Text = Holder;
            returning = false;
        }

        private void btn_five_Click(object sender, RoutedEventArgs e)
        {
            Holder = EnteringNumbers(5);
            txt_answer.Text = Holder;
            returning = false;
        }

        private void btn_six_Click(object sender, RoutedEventArgs e)
        {
            Holder = EnteringNumbers(6);
            txt_answer.Text = Holder;
            returning = false;
        }

        private void btn_seven_Click(object sender, RoutedEventArgs e)
        {
            Holder = EnteringNumbers(7);
            txt_answer.Text = Holder;
            returning = false;
        }

        private void btn_eight_Click(object sender, RoutedEventArgs e)
        {
            Holder = EnteringNumbers(8);
            txt_answer.Text = Holder;
            returning = false;
        }

        private void btn_nine_Click(object sender, RoutedEventArgs e)
        {
            Holder = EnteringNumbers(9);
            txt_answer.Text = Holder;
            returning = false;
        }

        private void btn_10_Click(object sender, RoutedEventArgs e)
        {
            var loader = Windows.ApplicationModel.Resources.ResourceLoader.GetForCurrentView();
            string ofText = loader.GetString("answerOf");
            if (!dec)
            {
                FirstDecimalHolder = First.ToString() + ".0";
                FirstDecimalWorking = Convert.ToDecimal(FirstDecimalHolder);
            }
            else
            {
                FirstDecimalWorking = Convert.ToDecimal(FirstTotal);
                dec = false;
            }
            Answer = FirstDecimalWorking * 0.1M;
            FirstHolder = FirstDecimalWorking.ToString();
            Holder = "10% " + ofText + " " + FirstHolder + " = " + Answer.ToString();
            txt_answer.Text = Holder;
            First = 0;
            FirstDecimal = 0;
            FirstDigit = true;
        }

        private void btn_25_Click(object sender, RoutedEventArgs e)
        {
            var loader = Windows.ApplicationModel.Resources.ResourceLoader.GetForCurrentView();
            string ofText = loader.GetString("answerOf");
            if (!dec)
            {
                FirstDecimalHolder = First.ToString() + ".0";
                FirstDecimalWorking = Convert.ToDecimal(FirstDecimalHolder);
            }
            else
            {
                FirstDecimalWorking = Convert.ToDecimal(FirstTotal);
                dec = false;
            }
            Answer = FirstDecimalWorking * 0.25M;
            FirstHolder = FirstDecimalWorking.ToString();
            Holder = "25% " + ofText + " " + FirstHolder + " = " + Answer.ToString();
            txt_answer.Text = Holder;
            First = 0;
            FirstDecimal = 0;
            FirstDigit = true;
        }

        private void btn_50_Click(object sender, RoutedEventArgs e)
        {
            var loader = Windows.ApplicationModel.Resources.ResourceLoader.GetForCurrentView();
            string ofText = loader.GetString("answerOf");
            if (!dec)
            {
                FirstDecimalHolder = First.ToString() + ".0";
                FirstDecimalWorking = Convert.ToDecimal(FirstDecimalHolder);
            }
            else
            {
                FirstDecimalWorking = Convert.ToDecimal(FirstTotal);
                dec = false;
            }
            Answer = FirstDecimalWorking * 0.5M;
            FirstHolder = FirstDecimalWorking.ToString();
            Holder = "50% " + ofText + " " + FirstHolder + " = " + Answer.ToString();
            txt_answer.Text = Holder;
            First = 0;
            FirstDecimal = 0;
            FirstDigit = true;
        }

        private void btn_zero_Click(object sender, RoutedEventArgs e)
        {
            Holder = EnteringNumbers(0);
            txt_answer.Text = Holder;
        }

        private void btn_pc_Click(object sender, RoutedEventArgs e)
        {
            if (!returning)
            {
                var loader = Windows.ApplicationModel.Resources.ResourceLoader.GetForCurrentView();
                string ofText = loader.GetString("answerOf");
                if (percentage)
                {
                    if (dec)
                    {
                        txt_answer.Text = "?% " + ofText + " " + FirstTotal;
                    }
                    else
                    {
                        txt_answer.Text = "?% " + ofText + " " + FirstHolder;
                        FirstTotal = FirstHolder;
                    }
                    percentage = false;
                    dec = false;
                    btn_pc.Content = "=";
                    FirstDigit = true;
                }
                else
                {
                    if (dec)
                    {
                        DecimalWorking();
                        dec = false;
                    }
                    else
                    {
                        SecondHolder = SecondHolder + ".0";
                        SecondTotal = SecondHolder;
                    }
                    SecondDecimalWorking = Convert.ToDecimal(SecondTotal);
                    FirstDecimalWorking = Convert.ToDecimal(FirstTotal);
                    SecondDecimalWorking = SecondDecimalWorking / 100;
                    Answer = FirstDecimalWorking * SecondDecimalWorking;
                    Holder = SecondTotal + "% " + ofText + " " + FirstTotal + " = " + Answer.ToString();
                    txt_answer.Text = Holder;
                    First = 0;
                    FirstDecimal = 0;
                    Second = 0;
                    SecondDecimal = 0;
                    btn_pc.Content = "%";
                    FirstDigit = true;
                    returning = true;
                }
            }
        }

        private void btn_dec_Click(object sender, RoutedEventArgs e)
        {
            if (!dec)
            {
                dec = true;
                if (percentage)
                {
                    if (FirstDecimal < 1)
                    {
                        Holder = First.ToString() + ".";
                    }
                    else
                    {
                        Holder = "0." + FirstDecimalHolder;
                        First = 0;
                    }
                }
                else
                {
                    if (SecondDecimal < 1)
                    {
                        Holder = Second.ToString() + ".";
                    }
                    else
                    {
                        Holder = "0." + SecondDecimalHolder;
                        Second = 0;
                    }
                }
                txt_answer.Text = Holder;
                FirstDigit = true;
            }
        }

        private void btn_Clear_Click(object sender, RoutedEventArgs e)
        {
            if (percentage)
            {
                First = 0;
                FirstDecimal = 0;
                FirstDecimalHolder = "";
                FirstDecimalLength = 0;
                FirstDecimalTempLength = 0;
                FirstDecimalWorking = 0;
                FirstHolder = "";
                FirstTotal = "";
            }
            else
            {
                Second = 0;
                SecondDecimal = 0;
                SecondDecimalHolder = "";
                SecondDecimalLength = 0;
                SecondDecimalTempLength = 0;
                SecondDecimalWorking = 0;
                SecondHolder = "";
                SecondTotal = "";
            }
            FirstDigit = true;
            returning = false;
            txt_answer.Text = "Cleared";
        }

        private void btn_Reset_Click(object sender, RoutedEventArgs e)
        {
            percentage = true;
            dec = false;
            FirstDigit = true;
            returning = false;
            FirstDecimal = 0;
            FirstDecimalHolder = "";
            FirstTotal = "";
            FirstHolder = "";
            First = 0;
            btn_pc.Content = "%";

            SecondDecimal = 0;
            SecondDecimalHolder = "";
            SecondTotal = "";
            SecondHolder = "";
            Second = 0;

            SecondDecimalTempLength = 0;
            SecondDecimalWorking = 0;
            SecondDecimalLength = 0;

            FirstDecimalTempLength = 0;
            FirstDecimalWorking = 0;
            FirstDecimalLength = 0;

            Holder = "";
            txt_answer.Text = "";
        }
    }
}
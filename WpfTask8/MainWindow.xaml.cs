using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfTask8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(fontName);
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            double fontSize = double.Parse(((sender as ComboBox).SelectedItem as TextBlock).Text);

            if (textBox != null)
            {
                textBox.FontSize = fontSize;

            }

        }


        private void Button_bold_text_Click(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                if (textBox.FontWeight != FontWeights.Bold)
                {
                    textBox.FontWeight = FontWeights.Bold;
                }
                else if (textBox.FontWeight == FontWeights.Bold)
                {
                    textBox.FontWeight = FontWeights.Normal;
                }
            }
        }

        private void Button_italic_text_Click(object sender, RoutedEventArgs e) { 
        
           
            if (textBox != null)
            {
                if (textBox.FontStyle != FontStyles.Italic)
                {
                    textBox.FontStyle = FontStyles.Italic;
                }
                else if (textBox.FontStyle == FontStyles.Italic)
                {
                    textBox.FontStyle = FontStyles.Normal;
                }
            }
        }

        private void Button_underlined_text_Click(object sender, RoutedEventArgs e)
        {

            if (textBox != null)
            {
                if (textBox.TextDecorations != TextDecorations.Underline)
                {
                    textBox.TextDecorations = TextDecorations.Underline;
                }
                else if (textBox.TextDecorations == TextDecorations.Underline)
                {
                    textBox.TextDecorations = null;
                }
            }
        }

        private void Radio_button_black_checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Black;
            }
        }

        private void Radio_button_red_checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Red;
            }
        }

        private void ExitExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void OpenExecute(object sender, ExecutedRoutedEventArgs e)
        {
            if (textBox != null)
            {
                StreamReader sr = new StreamReader("document.txt");

                textBox.Text = sr.ReadToEnd();
                sr.Close();
            }
            MessageBox.Show("Документ открыт");
        }

        private void SaveExecute(object sender, ExecutedRoutedEventArgs e)
        {
            if (textBox != null)
            {
                StreamWriter sw = new StreamWriter("document.txt");
                sw.Write(textBox.Text);
                sw.Close();
            }
            MessageBox.Show("Документ coxpaнен");
        }
    }
}

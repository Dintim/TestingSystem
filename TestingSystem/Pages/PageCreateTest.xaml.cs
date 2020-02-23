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
using TestingSystem.Lib;

namespace TestingSystem.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageCreateTest.xaml
    /// </summary>
    public partial class PageCreateTest : Page
    {        

        public PageCreateTest()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            MainWindow._test.Category = ((ComboBoxItem)comboBox.SelectedItem).Content.ToString();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {            
            MainWindow._test.Name = txbName.Text;
            MainWindow._test.Description = txbDescription.Text;
            MainWindow._test.QuestionsCnt = Convert.ToInt32(txbQuestionsCnt.Text);

            MainWindow._frame.Navigate(new PageCreateQuestions());
        }
    }
}

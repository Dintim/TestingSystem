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

namespace TestingSystem.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageCreateQuestions.xaml
    /// </summary>
    public partial class PageCreateQuestions : Page
    {
        public PageCreateQuestions()
        {
            InitializeComponent();
            
            for (int i = 0; i < MainWindow._test.QuestionsCnt; i++)
            {
                sPanel.Children.Add(new Label() { Content = "Текст вопроса: " });
                sPanel.Children.Add(new TextBox() { Width = 500, Height = 100, Name="txbQuestion_"+(i+1) });
                sPanel.Children.Add(new Label() { Content = "Варианты ответов: " });

                Grid grid = new Grid();
                grid.ColumnDefinitions.Add(new ColumnDefinition());
                grid.ColumnDefinitions.Add(new ColumnDefinition());
                grid.RowDefinitions.Add(new RowDefinition());
                grid.RowDefinitions.Add(new RowDefinition());
                grid.RowDefinitions.Add(new RowDefinition());

                Label label1 = new Label() { Content = "Ответ 1: " };
                Grid.SetColumn(label1, 0);
                Grid.SetColumn(label1, 0);
                Label label2 = new Label() { Content = "Ответ 2: " };
                Grid.SetColumn(label2, 0);
                Grid.SetColumn(label2, 1);
                Label label3 = new Label() { Content = "Ответ 3: " };
                Grid.SetColumn(label3, 0);
                Grid.SetColumn(label3, 2);

                TextBox txb1 = new TextBox() { Width=500, Height=100, Name="txbAns1_" + (i + 1) };
                Grid.SetColumn(txb1, 1);
                Grid.SetColumn(txb1, 0);
                TextBox txb2 = new TextBox() { Width = 500, Height = 100, Name = "txbAns2_" + (i + 1) };
                Grid.SetColumn(txb2, 1);
                Grid.SetColumn(txb2, 1);
                TextBox txb3 = new TextBox() { Width = 500, Height = 100, Name = "txbAns3_" + (i + 1) };
                Grid.SetColumn(txb3, 1);
                Grid.SetColumn(txb3, 2);

                grid.Children.Add(label1);
                grid.Children.Add(label2);
                grid.Children.Add(label3);
                grid.Children.Add(txb1);
                grid.Children.Add(txb2);
                grid.Children.Add(txb3);

                sPanel.Children.Add(grid);

                sPanel.Children.Add(new Label() { Content = "Правильный ответ: " });
                sPanel.Children.Add(new TextBox() { Width = 500, Height = 100, Name = "txbRightAns_" + (i + 1) });

                sPanel.Children.Add(new Label() { Content = "Баллы за вопрос: " });
                sPanel.Children.Add(new TextBox() { Width = 500, Height = 100, Name = "txbScore_" + (i + 1) });

            }
        }
    }
}

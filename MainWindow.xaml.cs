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

namespace FunWithAlgorithms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<int> MyList = new List<int>();
        public MainWindow()
        {
            InitializeComponent();

            Random rnd = new Random();

            for (int i = 0; i < 1000; i++)
            {
                MyList.Add(rnd.Next(0, 1000));
            }
            updateTextBox();
          
        }

        private void updateTextBox()
        {
            ListTextBox.SelectAll();

            ListTextBox.Selection.Text = "";
            ListTextBox.AppendText("");
            for (int i = 0; i < MyList.Count; i++)
            {
                ListTextBox.AppendText(MyList.ElementAt(i) + " ");
            }
        }

        //Recursive Bubble Sort
        private void SortButton_Click(object sender, RoutedEventArgs e)
        {
            BubleSort();
        }

        private void MergeSortBtn_Click(object sender, RoutedEventArgs e)
        {

        }


        public void BubleSort()
        {
            bool changeMade = false;
            int tmp;
            for (int i = 0; i < MyList.Count - 1; i++)
            {
                if (MyList[i + 1] < MyList[i])
                {
                    tmp = MyList[i + 1];
                    MyList[i + 1] = MyList[i];
                    MyList[i] = tmp;
                    changeMade = true;                
                }
            }
            if (changeMade)
                BubleSort();
            else
            {
                updateTextBox();
            }
        }


    }
}

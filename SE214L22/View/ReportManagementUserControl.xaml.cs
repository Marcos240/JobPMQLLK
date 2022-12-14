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

namespace SE214L22.View
{
    /// <summary>
    /// Interaction logic for ManagementReportUserControl.xaml
    /// </summary>
    public partial class ReportManagementUserControl : UserControl
    {
        public ReportManagementUserControl()
        {
            InitializeComponent();
        }

        private void searchMode_Loaded(object sender, RoutedEventArgs e)
        {
            searchMode.Items.Clear();
            searchMode.Items.Add("Theo ngày");
            searchMode.Items.Add("Theo tháng");
            searchMode.Items.Add("Theo quý");
            searchMode.Items.Add("Theo năm");
            searchMode.SelectedIndex = 0;
        }

        private void searchMode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (searchMode.SelectedIndex == 0)
            {
                searchDay.IsEnabled= true;
                searchDayArea.Visibility = Visibility.Visible;
                searchMonth.IsEnabled = false;
                searchMonthArea.Visibility = Visibility.Hidden;
                searchQuater.IsEnabled = false;
                searchQuaterArea.Visibility = Visibility.Hidden;
                searchYear.IsEnabled = false;
                searchYearArea.Visibility = Visibility.Hidden;
            }
            else if (searchMode.SelectedIndex == 1)
            {
                searchDay.IsEnabled = false;
                searchDayArea.Visibility = Visibility.Hidden;
                searchMonth.IsEnabled = true;
                searchMonthArea.Visibility = Visibility.Visible;
                searchQuater.IsEnabled = false;
                searchQuaterArea.Visibility = Visibility.Hidden;
                searchYear.IsEnabled = false;
                searchYearArea.Visibility = Visibility.Hidden;
            }
            else if (searchMode.SelectedIndex == 2)
            {
                searchDay.IsEnabled = false;
                searchDayArea.Visibility = Visibility.Hidden;
                searchMonth.IsEnabled = false;
                searchMonthArea.Visibility = Visibility.Hidden;
                searchQuater.IsEnabled = true;
                searchQuaterArea.Visibility= Visibility.Visible;
                searchYear.IsEnabled = false;
                searchYearArea.Visibility = Visibility.Hidden;
            }
            else
            {
                searchDay.IsEnabled = false;
                searchDayArea.Visibility = Visibility.Hidden;
                searchMonth.IsEnabled = false;
                searchMonthArea.Visibility = Visibility.Hidden;
                searchQuater.IsEnabled = false;
                searchQuaterArea.Visibility = Visibility.Hidden;
                searchYear.IsEnabled = true;
                searchYearArea.Visibility = Visibility.Visible;
            }    
        }

        private void searchMonth_Loaded(object sender, RoutedEventArgs e)
        {
            searchMonth.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                searchMonth.Items.Add(i);
            }
            //searchMonth.SelectedIndex = DateTime.Today.Month - 1;
        }

        private void searchDay_Loaded(object sender, RoutedEventArgs e)
        {
            searchDay.SelectedDate = DateTime.Now;
        }

        private void searchQuater_Loaded(object sender, RoutedEventArgs e)
        {
            searchQuater.Items.Clear();
            for (int i = 1; i <= 4; i++)
            {
                searchQuater.Items.Add(i);
            }
            //searchQuater.SelectedIndex = (DateTime.Today.Month + 2)/3 - 1;
        }

        private void searchYear_Loaded(object sender, RoutedEventArgs e)
        {
            searchYear.Items.Clear();
            for (int i = DateTime.Today.Year; i >= DateTime.Today.Year - 5; i --)
            {
                searchYear.Items.Add(i);
            }
            //searchYear.SelectedIndex = 0;
        }
    }
}

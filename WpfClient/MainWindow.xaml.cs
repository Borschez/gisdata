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

namespace WpfClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GisServiceReference.GisServiceClient gisServiceClient = null;

        private GisServiceReference.Prognosis currentPrognosis = null;

        public GisServiceReference.Prognosis CurrentPrognosis
        {
            get { return currentPrognosis; }
            set {
                if (value != null)
                {
                    currentPrognosis = value;
                    SetPrognosisData();
                }
                else
                {
                    throw new NullReferenceException();
                }
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gisServiceClient = new GisServiceReference.GisServiceClient();
            List<GisServiceReference.City> cities = gisServiceClient.GetAllCities().ToList();
            citiesComboBox.ItemsSource = cities;
            citiesComboBox.DisplayMemberPath = "Name";            
        }

        private void citiesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                GisServiceReference.City sel = (GisServiceReference.City)(sender as ComboBox).SelectedValue;
                CurrentPrognosis = gisServiceClient.GetLatestPrognosisByCity(sel.Id);
            }catch(NullReferenceException ex)
            {
                MessageBox.Show("Прогноз не найден!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SetPrognosisData()
        {
            tempLabel.Content = currentPrognosis.Air_temp;
            humLabel.Content = currentPrognosis.Humidity;
            descLabel.Content = currentPrognosis.Description;
            pressureLabel.Content = currentPrognosis.Pressure;
            dateLabel.Content = currentPrognosis.Date;
        }
    }
}

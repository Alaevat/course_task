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

namespace SituationsDataBase
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public SituationsDataBase.company_easyDataSet company_easyDataSet;
        public SituationsDataBase.company_easyDataSetTableAdapters.BillTableAdapter company_easyDataSetBillTableAdapter;
        public SituationsDataBase.company_easyDataSetTableAdapters.ContragentTableAdapter company_easyDataSetContragentTableAdapter;
        public SituationsDataBase.company_easyDataSetTableAdapters.ManagerTableAdapter company_easyDataSetManagerTableAdapter;
        public SituationsDataBase.company_easyDataSetTableAdapters.Order_СustomerTableAdapter company_easyDataSetOrder_СustomerTableAdapter;
        public SituationsDataBase.company_easyDataSetTableAdapters.PlanTableAdapter company_easyDataSetPlanTableAdapter;
        public SituationsDataBase.company_easyDataSetTableAdapters.ProductTableAdapter company_easyDataSetProductTableAdapter;
        public SituationsDataBase.company_easyDataSetTableAdapters.StorageTableAdapter company_easyDataSetStorageTableAdapter;
        public SituationsDataBase.company_easyDataSetTableAdapters.AnalysisTableAdapter company_easyDataSetAnalysisTableAdapter;
        public company_easyDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter;



        public MainWindow()
        {
            InitializeComponent();
            productDataGrid.Visibility = Visibility.Hidden;
            contragentDataGrid.Visibility = Visibility.Hidden;
            order_СustomerDataGrid.Visibility = Visibility.Hidden;
            managerDataGrid.Visibility = Visibility.Hidden;
            billDataGrid.Visibility = Visibility.Hidden;
            planDataGrid.Visibility = Visibility.Hidden;
            storageDataGrid.Visibility = Visibility.Hidden;
            analysisDataGrid.Visibility = Visibility.Hidden;
            analysisDataGrid.IsReadOnly = true;

        }

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {

            company_easyDataSet = ((SituationsDataBase.company_easyDataSet)(this.FindResource("company_easyDataSet")));
            // Загрузить данные в таблицу Order_Сustomer. Можно изменить этот код как требуется.
            SituationsDataBase.company_easyDataSetTableAdapters.Order_СustomerTableAdapter company_easyDataSetOrder_СustomerTableAdapter = new SituationsDataBase.company_easyDataSetTableAdapters.Order_СustomerTableAdapter();
            company_easyDataSetOrder_СustomerTableAdapter.Fill(company_easyDataSet.Order_Сustomer);
            System.Windows.Data.CollectionViewSource order_СustomerViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("order_СustomerViewSource")));
            order_СustomerViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу Analysis. Можно изменить этот код как требуется.
            company_easyDataSetAnalysisTableAdapter = new SituationsDataBase.company_easyDataSetTableAdapters.AnalysisTableAdapter();
            company_easyDataSetAnalysisTableAdapter.Fill(company_easyDataSet.Analysis);
            System.Windows.Data.CollectionViewSource analysisViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("analysisViewSource")));
            analysisViewSource.View.MoveCurrentToFirst();

            // Загрузить данные в таблицу Product. Можно изменить этот код как требуется.
            company_easyDataSetProductTableAdapter = new SituationsDataBase.company_easyDataSetTableAdapters.ProductTableAdapter();
            company_easyDataSetProductTableAdapter.Fill(company_easyDataSet.Product);
            System.Windows.Data.CollectionViewSource productViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("productViewSource")));
            productViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу Contragent. Можно изменить этот код как требуется.
            company_easyDataSetContragentTableAdapter = new SituationsDataBase.company_easyDataSetTableAdapters.ContragentTableAdapter();
            company_easyDataSetContragentTableAdapter.Fill(company_easyDataSet.Contragent);
            System.Windows.Data.CollectionViewSource contragentViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("contragentViewSource")));
            contragentViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу Manager. Можно изменить этот код как требуется.
            company_easyDataSetManagerTableAdapter = new SituationsDataBase.company_easyDataSetTableAdapters.ManagerTableAdapter();
            company_easyDataSetManagerTableAdapter.Fill(company_easyDataSet.Manager);
            System.Windows.Data.CollectionViewSource managerViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("managerViewSource")));
            managerViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу Bill. Можно изменить этот код как требуется.
            company_easyDataSetBillTableAdapter = new SituationsDataBase.company_easyDataSetTableAdapters.BillTableAdapter();
            company_easyDataSetBillTableAdapter.Fill(company_easyDataSet.Bill);
            System.Windows.Data.CollectionViewSource billViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("billViewSource")));
            billViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу Plan. Можно изменить этот код как требуется.
            company_easyDataSetPlanTableAdapter = new SituationsDataBase.company_easyDataSetTableAdapters.PlanTableAdapter();
            company_easyDataSetPlanTableAdapter.Fill(company_easyDataSet.Plan);
            System.Windows.Data.CollectionViewSource planViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("planViewSource")));
            planViewSource.View.MoveCurrentToFirst();
            // Загрузить данные в таблицу Storage. Можно изменить этот код как требуется.
            company_easyDataSetStorageTableAdapter = new SituationsDataBase.company_easyDataSetTableAdapters.StorageTableAdapter();
            company_easyDataSetStorageTableAdapter.Fill(company_easyDataSet.Storage);
            System.Windows.Data.CollectionViewSource storageViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("storageViewSource")));
            storageViewSource.View.MoveCurrentToFirst();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox.SelectedIndex == 0)
            {
                productDataGrid.Visibility = Visibility.Visible;
                contragentDataGrid.Visibility = Visibility.Hidden;
                order_СustomerDataGrid.Visibility = Visibility.Hidden;
                managerDataGrid.Visibility = Visibility.Hidden;
                billDataGrid.Visibility = Visibility.Hidden;
                planDataGrid.Visibility = Visibility.Hidden;
                storageDataGrid.Visibility = Visibility.Hidden;
                analysisDataGrid.Visibility = Visibility.Hidden;

            }
            if (comboBox.SelectedIndex == 1)
            {
                productDataGrid.Visibility = Visibility.Hidden;
                contragentDataGrid.Visibility = Visibility.Visible;
                order_СustomerDataGrid.Visibility = Visibility.Hidden;
                managerDataGrid.Visibility = Visibility.Hidden;
                billDataGrid.Visibility = Visibility.Hidden;
                planDataGrid.Visibility = Visibility.Hidden;
                storageDataGrid.Visibility = Visibility.Hidden;
                analysisDataGrid.Visibility = Visibility.Hidden;

            }
            if (comboBox.SelectedIndex == 2)
            {
                productDataGrid.Visibility = Visibility.Hidden;
                contragentDataGrid.Visibility = Visibility.Hidden;
                order_СustomerDataGrid.Visibility = Visibility.Visible;
                managerDataGrid.Visibility = Visibility.Hidden;
                billDataGrid.Visibility = Visibility.Hidden;
                planDataGrid.Visibility = Visibility.Hidden;
                storageDataGrid.Visibility = Visibility.Hidden;
                analysisDataGrid.Visibility = Visibility.Hidden;

            }
            if (comboBox.SelectedIndex == 3)
            {
                productDataGrid.Visibility = Visibility.Hidden;
                contragentDataGrid.Visibility = Visibility.Hidden;
                order_СustomerDataGrid.Visibility = Visibility.Hidden;
                managerDataGrid.Visibility = Visibility.Visible;
                billDataGrid.Visibility = Visibility.Hidden;
                planDataGrid.Visibility = Visibility.Hidden;
                storageDataGrid.Visibility = Visibility.Hidden;
                analysisDataGrid.Visibility = Visibility.Hidden;

            }
            if (comboBox.SelectedIndex == 4)
            {
                productDataGrid.Visibility = Visibility.Hidden;
                contragentDataGrid.Visibility = Visibility.Hidden;
                order_СustomerDataGrid.Visibility = Visibility.Hidden;
                managerDataGrid.Visibility = Visibility.Hidden;
                billDataGrid.Visibility = Visibility.Visible;
                planDataGrid.Visibility = Visibility.Hidden;
                storageDataGrid.Visibility = Visibility.Hidden;
                analysisDataGrid.Visibility = Visibility.Hidden;

            }
            if (comboBox.SelectedIndex == 5)
            {
                productDataGrid.Visibility = Visibility.Hidden;
                contragentDataGrid.Visibility = Visibility.Hidden;
                order_СustomerDataGrid.Visibility = Visibility.Hidden;
                managerDataGrid.Visibility = Visibility.Hidden;
                billDataGrid.Visibility = Visibility.Hidden;
                planDataGrid.Visibility = Visibility.Visible;
                storageDataGrid.Visibility = Visibility.Hidden;
                analysisDataGrid.Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 6)
            {
                productDataGrid.Visibility = Visibility.Hidden;
                contragentDataGrid.Visibility = Visibility.Hidden;
                order_СustomerDataGrid.Visibility = Visibility.Hidden;
                managerDataGrid.Visibility = Visibility.Hidden;
                billDataGrid.Visibility = Visibility.Hidden;
                planDataGrid.Visibility = Visibility.Hidden;
                storageDataGrid.Visibility = Visibility.Visible;
                analysisDataGrid.Visibility = Visibility.Hidden;
            }
            if(comboBox.SelectedIndex == 7)
            {
                productDataGrid.Visibility = Visibility.Hidden;
                contragentDataGrid.Visibility = Visibility.Hidden;
                order_СustomerDataGrid.Visibility = Visibility.Hidden;
                managerDataGrid.Visibility = Visibility.Hidden;
                billDataGrid.Visibility = Visibility.Hidden;
                planDataGrid.Visibility = Visibility.Hidden;
                storageDataGrid.Visibility = Visibility.Hidden;
                analysisDataGrid.Visibility = Visibility.Visible;
            }
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {

            company_easyDataSetProductTableAdapter.Update(company_easyDataSet.Product);
            company_easyDataSetContragentTableAdapter.Update(company_easyDataSet.Contragent);
            company_easyDataSetOrder_СustomerTableAdapter.Update(company_easyDataSet.Order_Сustomer);
            company_easyDataSetManagerTableAdapter.Update(company_easyDataSet.Manager);
            company_easyDataSetBillTableAdapter.Update(company_easyDataSet.Bill);
            company_easyDataSetPlanTableAdapter.Update(company_easyDataSet.Plan);
            company_easyDataSetStorageTableAdapter.Update(company_easyDataSet.Storage);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            queriesTableAdapter =  new company_easyDataSetTableAdapters.QueriesTableAdapter();
            //var k = queriesTableAdapter.analysis_creater();
            //MessageBox.Show(k.ToString());
            //queriesTableAdapter.analyzer_create();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
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
        public SituationsDataBase.company_easyDataSetTableAdapters.AnalyzerTableAdapter company_easyDataSetAnalyzerTableAdapter;
        public System.Windows.Data.CollectionViewSource analysisViewSource;
        public System.Windows.Data.CollectionViewSource analyzerViewSource;
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
            analyzerDataGrid.Visibility = Visibility.Hidden;
            analysisDataGrid.IsReadOnly = true;
            analyzerDataGrid.IsReadOnly = true;

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
            analysisViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("analysisViewSource")));
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
            // Загрузить данные в таблицу Analyzer. Можно изменить этот код как требуется.
            company_easyDataSetAnalyzerTableAdapter = new SituationsDataBase.company_easyDataSetTableAdapters.AnalyzerTableAdapter();
            company_easyDataSetAnalyzerTableAdapter.Fill(company_easyDataSet.Analyzer);
            analyzerViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("analyzerViewSource")));
            analyzerViewSource.View.MoveCurrentToFirst();
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
                analyzerDataGrid.Visibility = Visibility.Hidden;

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
                analyzerDataGrid.Visibility = Visibility.Hidden;

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
                analyzerDataGrid.Visibility = Visibility.Hidden;

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
                analyzerDataGrid.Visibility = Visibility.Hidden;

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
                analyzerDataGrid.Visibility = Visibility.Hidden;

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
                analyzerDataGrid.Visibility = Visibility.Hidden;
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
                analyzerDataGrid.Visibility = Visibility.Hidden;
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
                analyzerDataGrid.Visibility = Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 8)
            {
                productDataGrid.Visibility = Visibility.Hidden;
                contragentDataGrid.Visibility = Visibility.Hidden;
                order_СustomerDataGrid.Visibility = Visibility.Hidden;
                managerDataGrid.Visibility = Visibility.Hidden;
                billDataGrid.Visibility = Visibility.Hidden;
                planDataGrid.Visibility = Visibility.Hidden;
                storageDataGrid.Visibility = Visibility.Hidden;
                analysisDataGrid.Visibility = Visibility.Hidden;
                analyzerDataGrid.Visibility = Visibility.Visible;

            }
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (comboBox.SelectedIndex == 0)
                {
                    company_easyDataSetProductTableAdapter.Update(company_easyDataSet.Product);
                }
                if (comboBox.SelectedIndex == 1)
                {
                    company_easyDataSetContragentTableAdapter.Update(company_easyDataSet.Contragent);
                }
                if (comboBox.SelectedIndex == 2)
                {
                    company_easyDataSetOrder_СustomerTableAdapter.Update(company_easyDataSet.Order_Сustomer);
                }
                if (comboBox.SelectedIndex == 3)
                {
                    company_easyDataSetManagerTableAdapter.Update(company_easyDataSet.Manager);
                }
                if (comboBox.SelectedIndex == 4)
                {
                    company_easyDataSetBillTableAdapter.Update(company_easyDataSet.Bill);
                }
                if (comboBox.SelectedIndex == 5)
                {
                    company_easyDataSetPlanTableAdapter.Update(company_easyDataSet.Plan);
                }
                if (comboBox.SelectedIndex == 6)
                {
                    company_easyDataSetStorageTableAdapter.Update(company_easyDataSet.Storage);
                }
                company_easyDataSet.AcceptChanges();
            }
            catch(Exception ex2)
            {
                MessageBox.Show(ex2.Message + "/n" + ex2.Source);
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                queriesTableAdapter = new company_easyDataSetTableAdapters.QueriesTableAdapter();
                queriesTableAdapter.analysis_creater_2();
                queriesTableAdapter.analyzer_creater_2();
                company_easyDataSetAnalysisTableAdapter.Update(company_easyDataSet.Analysis);
                company_easyDataSetAnalyzerTableAdapter.Update(company_easyDataSet.Analyzer);
                company_easyDataSet.AcceptChanges();
                company_easyDataSetAnalyzerTableAdapter.Fill(company_easyDataSet.Analyzer);
                company_easyDataSetAnalysisTableAdapter.Fill(company_easyDataSet.Analysis);

                MessageBox.Show("Успешно");
            }
            catch(Exception ex1)
            {
                MessageBox.Show(ex1.Message + "/n" + ex1.Source);
            }
 
        }

        private void delete_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (comboBox.SelectedIndex == 7)
                {
                    DataRowView analysis_row = (DataRowView)analysisDataGrid.SelectedItems[0];
                    var current = analysis_row["ID_Analysis"];
                    var oldRow = company_easyDataSet.Analysis.FindByID_Analysis(Convert.ToInt32(current));
                    oldRow.Delete();
                    company_easyDataSetAnalysisTableAdapter.Update(company_easyDataSet.Analysis);
                    company_easyDataSet.AcceptChanges();
                }

                if (comboBox.SelectedIndex == 8)
                {
                    DataRowView row = (DataRowView)analyzerDataGrid.SelectedItems[0];
                    var current = row["ID_Analyzer"];
                    var oldRow = company_easyDataSet.Analyzer.FindByID_Analyzer(Convert.ToInt32(current));
                    //MessageBox.Show(current.ToString());
                    oldRow.Delete();
                    company_easyDataSetAnalyzerTableAdapter.Update(company_easyDataSet.Analyzer);
                    company_easyDataSet.AcceptChanges();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "/n" + ex.Source);
            }    
                 
        }
    }
}

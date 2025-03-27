using ScottPlot;
using ScottPlot.WinForms;
using System.Data;
using System.Windows.Forms;

namespace Graph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillTable();
        }

        private void FillTable()
        {
            string path = "C:\\Users\\rosal\\Downloads\\Automobile_data.CSV";
            string[] lines = File.ReadAllLines(path);
            string[] headers = lines[0].Split(',');
            DataTable dt = new DataTable();
            foreach (string header in headers)
            {
                dt.Columns.Add(header);
            }

            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');
                DataRow row = dt.NewRow();
                for (int j = 0; j < headers.Length; j++)
                    row[j] = data[j];
                dt.Rows.Add(row);
            }
            dtgvAutomovile.DataSource = dt;
        }
       
        private void btnFilter_Click(object sender, EventArgs e)
        {
            string selectedBrand = cmbFilter.Text;
            DataTable dt = (DataTable)dtgvAutomovile.DataSource;

            if (dt != null)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = $"Make = '{selectedBrand}'";
                DataTable filterTable = dv.ToTable();
                ProcessData(filterTable, "fuel-type", fmp1FuelType);
                ProcessData(filterTable, "aspiration", fmpNormalizedLosses);
                ProcessData(filterTable, "normalized-losses", fmpAspiration);
                ProcessData(filterTable, "num-of-doors", fmpNumofDoors);
                ProcessData(filterTable, "engine-location", fmpEngine);
            }

        }
        private void ProcessData(DataTable table, string columnName, FormsPlot plot)
        {
            Dictionary<string, double> countData = new Dictionary<string, double>();
            foreach (DataRow row in table.Rows)
            {
                string value = row[columnName].ToString().Trim().ToLower();

                if (!string.IsNullOrEmpty(value))
                {
                    if (countData.ContainsKey(value))
                        countData[value]++;
                    else
                        countData[value] = 1;
                }
            }
            double[] values = countData.Values.ToArray();
            string[] labels = countData.Keys.ToArray();
            CreatePie(values, labels, plot, columnName);
        }
        private void CreatePie(double[] values, string[] labels, FormsPlot plot, string title)
        {
            plot.Plot.Clear();
            var pie = plot.Plot.Add.Pie(values);
            pie.ExplodeFraction = .1;
            pie.SliceLabelDistance = 0.5;

            double total = values.Sum();
            double[] percentages = values.Select(x => x / total * 100).ToArray();

            for (int i = 0; i < values.Length; i++)
            {
                pie.Slices[i].Label = $"{labels[i]} ({percentages[i]:0.0}%)";
                pie.Slices[i].LabelFontSize = 14;
                pie.Slices[i].LabelBold = true;
                pie.Slices[i].LabelFontColor = Colors.Green.WithAlpha(.7);
            }
            plot.Plot.Title("Distribution of " + title);
            plot.Plot.Axes.Frameless();
            plot.Plot.HideGrid();
            plot.Plot.Axes.AutoScale();
            plot.Refresh();
        }
    }
}

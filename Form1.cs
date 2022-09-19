using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Practica_Chart
{
    public partial class Form1 : Form
    {
        int[] conjunto = { 12, 32, 345, 12, 65, 3 };
        string[] datos = { "A", "B", "C", "D", "E", "F" };
        Burbuja b;
        public Form1()
        {
            InitializeComponent();
            b = new Burbuja(conjunto);
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            b.Ordenar();
            conjunto = b.Conjunto;

            Series series = this.Chart.Series.Add("Total");
            this.Chart.Series.Clear();

            this.Chart.Palette = ChartColorPalette.SeaGreen;
            this.Chart.Titles.Add("Ventas");
            for(int i = 0; i < conjunto.Length; i++)
            {
                series = this.Chart.Series.Add(datos[i]);
                series.Points.Add(conjunto[i]);
            }
        }

        
    }
}

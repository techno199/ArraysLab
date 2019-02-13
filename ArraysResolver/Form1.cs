using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraysResolver
{
    public partial class Form1 : Form
    {
        public int[][] MyArray { get; set; }
        public const int maxAxisLength = 15;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRandomize_Click(object sender, EventArgs e)
        {
            UpdateDataGridUI();
        }

        private void randomizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDataGridUI();
        }

        public void UpdateDataGridUI()
        {
            dataGridViewArrays.Rows.Clear();
            dataGridViewArrays.Columns.Clear();

            var random = new Random();
            var columnsCount = (int)numericUpDownColumns.Value;
            var rowsCount = (int)numericUpDownRows.Value;

            for (int i = 0; i < columnsCount; i++)
            {
                dataGridViewArrays.Columns.Add($"col{i}", $"col{i}");
            }

            MyArray = new int[rowsCount][];
            for (int i = 0; i < rowsCount; i++)
            {
                var stringValues = new string[columnsCount];
                var values = new int[columnsCount];
                for (int j = 0; j < columnsCount; j++)
                {
                    values[j] = random.Next(-5, 5);
                    stringValues[j] = values[j].ToString();
                }
                MyArray[i] = values;

                dataGridViewArrays.Rows.Add(stringValues);
            }
        }

        private void dataGridViewArrays_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var newValue = Int32.Parse(dataGridViewArrays[e.ColumnIndex, e.RowIndex].Value.ToString());
                MyArray[e.RowIndex][e.ColumnIndex] = newValue;
            }
            catch
            {
                MessageBox.Show("Введите валидную чиселку(целую)");
            }
        }

        private void buttonEvaluateTaskSeven_Click(object sender, EventArgs e)
        {
            EvaluateTaskSeven();
        }

        private void evaluateTaskSevenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EvaluateTaskSeven();
        }

        public void EvaluateTaskSeven()
        {
            var columnsCount = (int)numericUpDownColumns.Value;
            var rowsCount = (int)numericUpDownRows.Value;
            if (MyArray == null || MyArray.Length == 0)
            {
                MessageBox.Show("Сначала надо заполнить массивы");
                return;
            }

            var totalPositiveColumns = 0;

            for (int columnIndex = 0; columnIndex < columnsCount; columnIndex++)
            {
                var columnValuesEvaluation = 0;

                for (int rowIndex = 0; rowIndex < rowsCount; rowIndex++)
                {
                    if (MyArray[rowIndex][columnIndex] >= 0)
                    {
                        columnValuesEvaluation++;
                    }
                    else
                    {
                        columnValuesEvaluation--;
                    }
                }

                if (columnValuesEvaluation > 0) totalPositiveColumns++;
                else if (columnValuesEvaluation < 0) totalPositiveColumns--;
            }

            if (totalPositiveColumns > 0)
                MessageBox.Show($"Количество столбцов, в которых неотрицательных чисел больше, равно {totalPositiveColumns}");
            else if (totalPositiveColumns == 0)
                MessageBox.Show("Количество столбцов с преобладанием неотрицательных чисел равно количеству столбцов, где отрицательных чисел больше");
            else
                MessageBox.Show($"Количество столбцов, в которых отрицательных чисел больше, равно {totalPositiveColumns * -1}");

        }
    }
}

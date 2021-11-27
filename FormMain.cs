using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BubbleSort_Visualiser
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            comboBoxSortOrder.SelectedIndex = 0;
            buttonNextStep.Enabled = false;
            labels = panelArray.Controls
                .OfType<Label>()
                .OrderBy(x => x.Name)
                .ToArray();
            panelArray.Visible = false;
            labelInfo.BackColor = Color.FromArgb(250, 223, 99);
        }

        private int[] arr;

        // "Ascending" or "Descending"
        private string sortOrder;

        // labels for the values in the array
        private Label[] labels;

        // steps of the BubbleSort algorithm are recorded in a queue to be processed visually
        private Queue<Step> steps = new Queue<Step>();
        private int lastStepOuterIdx;
        private Step currentStep;
        private bool sorted;

        protected override void OnPaint(PaintEventArgs e)
        {
            if (currentStep != null && steps.Count > 0)
            {
                foreach (var label in labels)
                {
                    if (label.Name == "label" + $"{currentStep.LeftIdx}"
                        || label.Name == "label" + $"{currentStep.RightIdx}"
                        || label.BackColor.ToArgb() == Color.FromArgb(181, 244, 74).ToArgb())
                    {
                        continue;
                    }

                    label.BackColor = Color.White;
                }
            }
            else if (sorted)
            {
                labels[0].BackColor = Color.FromArgb(181, 244, 74);
                labels[1].BackColor = Color.FromArgb(181, 244, 74);
            }
        }

        private int[] GenerateArray()
        {
            Random r = new Random();

            return Enumerable.Range(0, 8)
                .Select(n => r.Next(100))
                .ToArray();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            ResetValues();
            arr = GenerateArray();
            panelArray.Visible = true;

            SetVisualsForUnsorted(sortOrder);
            BubbleSort(arr, sortOrder);
            SetTotalSteps();
            UpdateStepsLeft();

            Invalidate();
        }


        private void buttonNextStep_Click(object sender, EventArgs e)
        {
            if (steps.Count > 0)
            {
                currentStep = steps.Dequeue();
                currentStep.ShowStep(labels);

                labelSwap.Text = currentStep.isSwap
                    ? "Swap!"
                    : "";

                if (currentStep.outerIdx != lastStepOuterIdx)
                    labels[arr.Length - lastStepOuterIdx - 1].BackColor = Color.FromArgb(181, 244, 74);

                lastStepOuterIdx = currentStep.outerIdx;
            }
            else
            {
                sorted = true;
                SetVisualsForSorted();
            }

            UpdateStepsLeft();
            Invalidate();
        }

        private void BubbleSort(int[] arr, string order)
        {
            Step currentStep;
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    currentStep = new Step()
                    {
                        LeftIdx = j,
                        LeftIdxValue = arr[j],
                        RightIdx = j + 1,
                        RightIdxValue = arr[j + 1],
                        outerIdx = i
                    };
                    steps.Enqueue(currentStep);

                    if (order == "Ascending" && arr[j] > arr[j + 1])
                    {
                        currentStep = new Step()
                        {
                            LeftIdx = j,
                            LeftIdxValue = arr[j],
                            RightIdx = j + 1,
                            RightIdxValue = arr[j + 1],
                            outerIdx = i,
                            isSwap = true
                        };

                        var temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;

                        steps.Enqueue(currentStep);
                    }
                    else if (order == "Descending" && arr[j] < arr[j + 1])
                    {

                        currentStep = new Step()
                        {
                            LeftIdx = j,
                            LeftIdxValue = arr[j],
                            RightIdx = j + 1,
                            RightIdxValue = arr[j + 1],
                            outerIdx = i,
                            isSwap = true
                        };

                        var temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;

                        steps.Enqueue(currentStep);
                    }
                }
            }
        }

        private void ResetValues()
        {
            sorted = false;
            currentStep = null;
            lastStepOuterIdx = 0;
            steps.Clear();
        }

        private void SetVisualsForUnsorted(string order)
        {
            labelInfo.Text = order == "Ascending"
                ? $"The array will be sorted in {order} order. If the number in red is bigger than the number in yellow they swap places."
                : $"The array will be sorted in {order} order. If the number in red is smaller than the number in yellow they swap places.";

            labelInfo.BackColor = Color.FromArgb(250, 223, 99);
            buttonNextStep.Enabled = true;
            labelSwap.Text = "";

            for (int i = 0; i < labels.Length; i++)
            {
                labels[i].BackColor = Color.White;
                labels[i].Text = $"{arr[i]}";
            }
        }

        private void SetVisualsForSorted()
        {
            labelInfo.Text = "The array is sorted!";
            labelInfo.BackColor = Color.GreenYellow;
            buttonNextStep.Enabled = false;
            labelSwap.Text = "";
        }

        private void SetTotalSteps()
        {
            labelStepsTotal.Text = $"Total steps: {steps.Count}\n" +
                            $"Comparisons: {steps.Where(x => !x.isSwap).Count()}\n" +
                            $"Swaps: {steps.Where(x => x.isSwap).Count()}";
        }

        private void UpdateStepsLeft()
        {
            labelStepsLeft.Text = $"Steps left: {steps.Count}";
        }

        private void comboBoxSortType_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortOrder = comboBoxSortOrder.SelectedItem.ToString();
        }
    }
}

using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BubbleSort_Visualiser
{
    class Step
    {
        public int LeftIdx { get; set; }
        public int RightIdx { get; set; }
        public int LeftIdxValue { get; set; }
        public int RightIdxValue { get; set; }
        public bool isSwap { get; set; }
        public int outerIdx { get; set; }

        public void ShowStep(Label[] labels)
        {
            Label l1 = labels.First(x => x.Name == "label" + $"{LeftIdx}");
            Label l2 = labels.First(x => x.Name == "label" + $"{RightIdx}");

            l1.BackColor = Color.Tomato;
            l2.BackColor = Color.Gold;

            if (isSwap)
            {
                var temp = l1.BackColor;
                l1.BackColor = l2.BackColor;
                l2.BackColor = temp;
                l1.Text = RightIdxValue.ToString();
                l2.Text = LeftIdxValue.ToString();
            }
        }
    }
}

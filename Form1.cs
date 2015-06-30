using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  //Load the interface
            Areas Location = new Areas("area0", "area1", "You have entered the area0");  //Set area to 0
            imageBox.Image = Properties.Resources.area1;
            inputBox.Text = Location.areaText;
            outputBox.Text = Location.areaText;
            MessageBox.Show (Location.areaText);
        }
    }
}

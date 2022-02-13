using ezOverLay;
using swed32;


namespace esptemp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            // 234234
            ez ez = new ez();
            swed swed = new swed();
            ez.SetInvi(this);
            ez.DoStuff("Counter-Strike: Global Offensive - Direct3D 9", this);
           // ez.StartLoop(10, "Counter-Strike: Global Offensive - Direct3D 9", this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var enemypen = new Pen(Color.Red, 3);
            Graphics graphics = e.Graphics;
            graphics.DrawLine(enemypen, Width / 2, Height, Width / 2, Height / 2);
            graphics.DrawLine(enemypen,0,0, Width / 2,Height / 2);
        }
    }
}
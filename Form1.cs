
namespace FunFX_Demo
{
    public partial class BounceForm : Form
    {
        //Declaration to implement BounceHandler Methods
        BounceHandler handler = new BounceHandler();

        public BounceForm()
        {
            InitializeComponent();
        }

        private void Ticker_Tick(object sender, EventArgs e) //Upon Tick
        {
            //Input Values, outputs new point the box moves to next tick
            Bouncer.Location = handler.DirectionDecider(Bouncer, Width, Height); 
        }
    }

    public class BounceHandler
    {
        int XIncrementer = 1; //How much the X value changes per tick. +Right -Left
        int YIncrementer = 1; //How much the Y value changes per tick. +Down -Up 
        int colourSwitcher = 1; //Used to decide the color. Dont touch.

        //Accepts the input in the form of a Box for use of its properties, and the Width and height of the Container the box is in
        public Point DirectionDecider(PictureBox box, float Width, float Height)
        {
            //Size of the box is accounted for with Dimension - Box.Width OR Box.Height
            if (box.Location.X <= 0 || box.Location.X >= (Width - box.Size.Width)) //If It touches the left or right border
            {
                XIncrementer = XIncrementer * -1; //Inverts direction
                box.BackColor = switchColour(); //Changes color
            }
            else if (box.Location.Y <= 0 || box.Location.Y >= (Height - box.Size.Height)) //If it touches the top or bottom border
            {
                YIncrementer = YIncrementer * -1; //Inverts direction
                box.BackColor = switchColour(); //Changes color
            }
            return new Point(box.Location.X + XIncrementer, box.Location.Y + YIncrementer); //Creates a new point, "adding" to current pos
        }

        //Cycles through the colors. Feel free to change. Last Case must revert back to 1
        public Color switchColour()
        {
            Color outputColour;
            switch (colourSwitcher)
            {
                case 1: colourSwitcher++; outputColour = Color.Red; break;
                case 2: colourSwitcher++; outputColour = Color.Blue; break;
                case 3: colourSwitcher = 1; outputColour = Color.Green; break;
                default: outputColour = Color.Red; break;
            }
            return outputColour;
        }
    }
}
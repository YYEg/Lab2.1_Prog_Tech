namespace Lab2._1_Prog_Tech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }

    public class Logic
    {
        public static double CalculateSquareArea(int squareSide)
        {
            double squareArea = Math.Pow(squareSide, 2);
            return squareArea;
        }

        public static double CalculateCircleArea(int circleRadius)
        {
            double circleArea = Math.Pow(circleRadius, 2) * 3.14;
            return circleArea;
        }

        public static string Compare(double squareArea, double circleArea)
        {

            string outMessage = "";
            if (squareArea > circleArea)
            {
                outMessage = "Площадь квадрата больше площади круга!";
            }
            else if (circleArea > squareArea)
            {
                outMessage = "Площадь круга больше площади квадрата!";
            }
            else
            {
                outMessage = "Площади круга и квадрата одинаковы!";
            }
            return outMessage;
        }

        public static string DoCompare(int squareSide, int circleRadius)
        {
            double squareArea = Logic.CalculateSquareArea(squareSide);
            double circleArea = Logic.CalculateCircleArea(circleRadius);
            string outMessage = Logic.Compare(squareArea, circleArea);
            return outMessage;
        }
    }
}
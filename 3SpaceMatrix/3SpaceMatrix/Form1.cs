using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;


namespace _3SpaceMatrix
{
    public partial class Form1 : Form
    {
        double t = 0;
        Vec4 viewPoint = new Vec4(0, 0, 1, 0);
        Vec4 viewPlane = new Vec4(0, 0, 1, 0);
        Vec3 origin = new Vec3(0, 0, 0);
        Vec3 xAxis = new Vec3(1,0,0);
        Vec3 yAxis = new Vec3(0, 1, 0);
        Vec4 viewWindow = new Vec4(-25, 25, -25, 25);
        Vec4 deviceWindow = new Vec4(0, 900, 0, 450);
        Matrix<double> VP;
        Matrix<double> swordMatrix;

        //PointF[] model_F;
        //Matrix<double> model;



        //F = points
        //L = line pairs 
        PointF[] axisMarker_F;
        PointF[] grid_L;
        PointF[] cube_L;
        
        PointF[] file_F;
        List<List<int>> file_V;

        public Form1()
        {
            InitializeComponent();
              

            //GARBAGE
            VP1.Text = "" + viewPoint.a;
            VP2.Text = "" + viewPoint.b;
            VP3.Text = "" + viewPoint.c;
            VP4.Text = "" + viewPoint.d;

            VPl1.Text = "" + viewPlane.a;
            VPl2.Text = "" + viewPlane.b;
            VPl3.Text = "" + viewPlane.c;
            VPl4.Text = "" + viewPlane.d;

            O1.Text = "" + origin.i;
            O2.Text = "" + origin.j;
            O3.Text = "" + origin.k;

            X1.Text = "" + xAxis.i;
            X2.Text = "" + xAxis.j;
            X3.Text = "" + xAxis.k;

            Y1.Text = "" + yAxis.i;
            Y2.Text = "" + yAxis.j;
            Y3.Text = "" + yAxis.k;

            VW1.Text = "" + viewWindow.a;
            VW2.Text = "" + viewWindow.b;
            VW3.Text = "" + viewWindow.c;
            VW4.Text = "" + viewWindow.d;

            DW1.Text = "" + deviceWindow.a;
            DW2.Text = "" + deviceWindow.b;
            DW3.Text = "" + deviceWindow.c;
            DW4.Text = "" + deviceWindow.d;




        }
        private void Form1_Load(object sender, EventArgs e)
        {
            VP = viewingPipeLine(viewPoint, viewPlane, origin, xAxis, yAxis, viewWindow, deviceWindow);
            
            PLY_loader sword = new PLY_loader("sword.ply");
            swordMatrix = sword.xyz_PLYtoMatrixz();
            file_V = sword.getVerticies();
            Console.WriteLine("file_V[0] Count: " + file_V[0].Count);

            updateFile();
            Draw();
        }
        private void Draw()
        {

            Bitmap bm = new Bitmap(canvas.ClientSize.Width, canvas.ClientSize.Width);
            using (Graphics gr = Graphics.FromImage(bm))
            {

                //hard code the axis 
                //gr.DrawLine(Pens.Blue, axisMarker_F[0], axisMarker_F[1]);
                //gr.DrawLine(Pens.Green, axisMarker_F[0], axisMarker_F[2]);
                //gr.DrawLine(Pens.Red, axisMarker_F[0], axisMarker_F[3]);


                
                for (int i = 0; i < file_F.Length-1; i += 1)
                {
                    //Console.WriteLine("(" + file_L[i].X + ", " + file_L[i] + ") -> (" + file_L[i + 1].X + ", " + file_L[i + 1].Y + ") ");
                   gr.DrawLine(Pens.Red, file_F[i], file_F[i + 1]);
                }

                for (int i = 0; i < file_V.Count; i++)
                {
                    PointF[] a = new PointF[file_V[i].Count -1];
                    for (int j = 1; j < file_V[i].Count; j++)
                    {

                        a[j - 1] = file_F[file_V[i][j]];

                    }
                    gr.FillPolygon(new SolidBrush(Color.Blue), a);                    
                
                }



               
            }
            canvas.Image = bm;
        }


        private void CalculateButton_Click(object sender, EventArgs e)
        {
            viewPoint = new Vec4(double.Parse(VP1.Text), double.Parse(VP2.Text), double.Parse(VP3.Text), double.Parse(VP4.Text));
            viewPlane = new Vec4(double.Parse(VPl1.Text), double.Parse(VPl2.Text), double.Parse(VPl3.Text), double.Parse(VPl4.Text));
            origin = new Vec3(double.Parse(O1.Text), double.Parse(O2.Text), double.Parse(O3.Text));
            xAxis = new Vec3(double.Parse(X1.Text), double.Parse(X2.Text), double.Parse(X3.Text));
            yAxis = new Vec3(double.Parse(Y1.Text), double.Parse(Y2.Text), double.Parse(Y3.Text));
            viewWindow = new Vec4(double.Parse(VW1.Text), double.Parse(VW2.Text), double.Parse(VW3.Text), double.Parse(VW4.Text));
            deviceWindow = new Vec4(double.Parse(DW1.Text), double.Parse(DW2.Text), double.Parse(DW3.Text), double.Parse(DW4.Text));
            Console.WriteLine("View settings updated");

            VP = viewingPipeLine(viewPoint, viewPlane, origin, xAxis, yAxis, viewWindow, deviceWindow);
            
          
            Draw();
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            t += .01;
           

            //updates:
            updateFile();
           
            Draw();
        }

        //update 3D objects
        private void updateModel()
        {
            //model_F = matrixToPointF(model * VP);
        }
        private void updateGrid()
        {
            grid_L = matrixToPointF(generateGrid() * S(3, 3, 3) * VP);
        }
        private void updateCube()
        {
            //cube_L = matrixToPointF(generateRubiksCube() * S(3, 3, 3) * rotArbitraryLine(new Vec3(2,0,1), new Vec3(1,8,9), t) * VP);
        }
        private void updateAxis()
        {
            axisMarker_F = matrixToPointF(DenseMatrix.OfArray(new double[,]
            {{0, 0, 0, 1},
            {1, 0, 0, 1 },
            {0, 1, 0, 1 },
            {0, 0, 1, 1 }}) * VP);
        }
        private void updateFile()
        {
            file_F = matrixToPointF(swordMatrix * S(2, 2, 2) * rotArbitraryLine(new Vec3(1, 1, 3), new Vec3(0, 2, 0), t) * VP);
        }

        //views
        private void orthographicView()
        {
            //page 86
            //plane z = 0

            viewPoint = new Vec4(0, 0, 1, 0);
            viewPlane = new Vec4(0, 0, 1, 0);


        }
    }
}

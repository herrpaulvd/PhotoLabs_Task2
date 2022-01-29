using Emgu.CV;
using Emgu.CV.Structure;
using static Emgu.CV.CvInvoke;

Console.Write("Input file name: ");
var mat = Imread(Console.ReadLine());
CvtColor(mat, mat, Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv);
var img = mat.ToImage<Hsv, byte>();
img[1] *= 1.5;
CvtColor(img, img, Emgu.CV.CvEnum.ColorConversion.Hsv2Bgr);
Imwrite("result.jpg", img);
Console.WriteLine("Successful");

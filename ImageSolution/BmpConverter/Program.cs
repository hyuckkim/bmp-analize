using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

foreach (FileInfo file in new DirectoryInfo("images").GetFiles())
{
    string filebody = file.FullName.Split('.').First();
    Image img = Image.FromFile(file.FullName);

    img.Save($"{filebody}.png", ImageFormat.Png);
    img.Save($"{filebody}.jpeg", ImageFormat.Jpeg);
    img.Save($"{filebody}.gif", ImageFormat.Gif);
    img.Save($"{filebody}-0.bmp", ImageFormat.Bmp);
}
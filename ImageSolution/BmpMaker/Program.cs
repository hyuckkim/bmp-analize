using System.IO;

Random random = new Random();

byte[] system = new byte[] { 
    0x42, 0x4D, 0x8A, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x9A, 0x00, 0x00, 0x00, 0x7C, 0x00, 
    0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x14, 0x00, 0x00, 0x00, 0x01, 0x00, 0x04, 0x00, 0x00, 0x00, 
    0x00, 0x00, 0xF0, 0x00, 0x00, 0x00, 0xD4, 0x2D, 0x00, 0x00, 0xD4, 0x2D, 0x00, 0x00, 0x04, 0x00, 
    0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0xFF, 0x00, 0x00, 0xFF, 0x00, 
    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x42, 0x47, 0x52, 0x73, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 
    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
byte[] color1 = new byte[] { 0x00, 0x00, 0x00, 0x00 };
byte[] color2 = new byte[] { 0xff, 0x00, 0x00, 0x00 };
byte[] color3 = new byte[] { 0x00, 0xff, 0x00, 0x00 };
byte[] color4 = new byte[] { 0x00, 0x00, 0xff, 0x00 };
byte[] content = new byte[] { 
    0x22, 0x22, 0x22, 0x22, 0x22, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x22, 0x22, 0x22, 0x22, 
    0x22, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x22, 0x22, 0x22, 0x22, 0x22, 0x00, 0x00, 0x00, 
    0x00, 0x00, 0x00, 0x00, 0x22, 0x22, 0x22, 0x22, 0x22, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
    0x22, 0x22, 0x22, 0x22, 0x22, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x22, 0x22, 0x22, 0x22, 
    0x22, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x22, 0x22, 0x22, 0x22, 0x22, 0x00, 0x00, 0x00, 
    0x00, 0x00, 0x00, 0x00, 0x22, 0x22, 0x22, 0x22, 0x22, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
    0x22, 0x22, 0x22, 0x22, 0x22, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x22, 0x22, 0x22, 0x22, 
    0x22, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x33, 0x33, 0x33, 0x33, 0x33, 0x11, 0x11, 0x11, 
    0x11, 0x11, 0x00, 0x00, 0x33, 0x33, 0x33, 0x33, 0x33, 0x11, 0x11, 0x11, 0x11, 0x11, 0x00, 0x00, 
    0x33, 0x33, 0x33, 0x33, 0x33, 0x11, 0x11, 0x11, 0x11, 0x11, 0x00, 0x00, 0x33, 0x33, 0x33, 0x33, 
    0x33, 0x11, 0x11, 0x11, 0x11, 0x11, 0x00, 0x00, 0x33, 0x33, 0x33, 0x33, 0x33, 0x11, 0x11, 0x11, 
    0x11, 0x11, 0x00, 0x00, 0x33, 0x33, 0x33, 0x33, 0x33, 0x11, 0x11, 0x11, 0x11, 0x11, 0x00, 0x00, 
    0x33, 0x33, 0x33, 0x33, 0x33, 0x11, 0x11, 0x11, 0x11, 0x11, 0x00, 0x00, 0x33, 0x33, 0x33, 0x33,
    0x33, 0x11, 0x11, 0x11, 0x11, 0x11, 0x00, 0x00, 0x33, 0x33, 0x33, 0x33, 0x33, 0x11, 0x11, 0x11, 
    0x11, 0x11, 0x00, 0x00, 0x33, 0x33, 0x33, 0x33, 0x33, 0x11, 0x11, 0x11, 0x11, 0x11, 0x00, 0x00
};
string fileName;
for (int i = 0; i < 1000; i++)
{
    fileName = string.Format("images/{0,4:D4}.bmp", i);
    random.NextBytes(color1);
    random.NextBytes(color2);
    random.NextBytes(color3);
    random.NextBytes(color4);
    BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create));
    writer.Write(system);
    writer.Write(color1);
    writer.Write(color2);
    writer.Write(color3);
    writer.Write(color4);
    writer.Write(content);
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaLider.Core
{
    class Qr
    {
        public Bitmap GenerarImagen(String texto, int tamano = 5)
        {
            QRCoder.QRCodeGenerator QR = new QRCoder.QRCodeGenerator();
            ASCIIEncoding ASSCII = new ASCIIEncoding();
            var z = QR.CreateQrCode(ASSCII.GetBytes(texto), QRCoder.QRCodeGenerator.ECCLevel.H);
            QRCoder.PngByteQRCode png = new QRCoder.PngByteQRCode();
            png.SetQRCodeData(z);
            var arr = png.GetGraphic(tamano);
            MemoryStream ms = new MemoryStream();
            ms.Write(arr, 0, arr.Length);
            return new Bitmap(ms);
        }
    }
}

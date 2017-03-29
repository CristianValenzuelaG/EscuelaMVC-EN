using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Web;

namespace EscuelaMVC.Comun
{
    public class ToolImage
    {
        public static Bitmap Base64StringToBitmap(string base64String)
        {
            Bitmap bmpReturn = null;

            byte[] byteBuffer = Convert.FromBase64String(base64String);
            MemoryStream memoryStream = new MemoryStream(byteBuffer);

            memoryStream.Position = 0;

            bmpReturn = (Bitmap)Bitmap.FromStream(memoryStream);

            memoryStream.Close();
            memoryStream = null;
            byteBuffer = null;

            return bmpReturn;
        }

        public static string ToBase64String(Bitmap bmp, ImageFormat imageFormat)
        {
            string base64String = string.Empty;

            MemoryStream memoryStream = new MemoryStream();
            bmp.Save(memoryStream, imageFormat);

            memoryStream.Position = 0;
            byte[] byteBuffer = memoryStream.ToArray();

            memoryStream.Close();

            base64String = Convert.ToBase64String(byteBuffer);
            byteBuffer = null;

            return base64String;
        }

        public static byte[] BitmapToBytes(Bitmap img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        /// <summary>
        /// FUNCION QUE CARGA LA IMAGEN LOCAL (DEFAULT) LA COMBIERTE A BITMAP Y LA COMBIERTE A TEXTO         
        /// 
        /// IP CAMARA:
        /// http://www.camera-sdk.com/p_53-how-to-take-a-picture-snapshot-and-save-it-as-jpg-in-c-onvif.html
        /// </summary>
        /// <param name="imgDEfault">Nombre de la Imagen a Cargar</param>
        /// <returns>texto base 64 de la imagen</returns>
        //public static string CargarImagenDefault(String imgDEfault = "coche_silueta.jpg")
        //{
        //    string txtImagen = "";
        //    String path = Path.Combine(MediaTypeNames.Application.StartupPath, String.Format("Comun\\{0}", imgDEfault));
        //    if (File.Exists(path))
        //    {
        //        Bitmap imagen = new System.Drawing.Bitmap(path);
        //        txtImagen = ToBase64String(imagen, ImageFormat.Jpeg);
        //    }

        //    return txtImagen;
        //}
    }
}
﻿using System;
using System.IO;
using System.Text;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Media;

namespace SvgSampleLibrary
{
    public static class Helpers
    {
        public static ImageSource ToImageSource(
            string svg,
            int width,
            int height)
        {
            using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(svg)))
            {
                stream.Seek(0, SeekOrigin.Begin);

                SvgImageSource imageSource = new SvgImageSource()
                {
                    RasterizePixelWidth = width,
                    RasterizePixelHeight = height,
                };
                imageSource.SetSourceAsync(stream.AsRandomAccessStream()).AsTask();
                return imageSource;
            }
        }


        public const string SampleSvg = "<svg xmlns=\"http://www.w3.org/2000/svg\" baseProfile=\"tiny\" viewBox=\"0 0 128 128\" overflow=\"visible\" fill=\"#fff\" xmlns:v=\"https://vecta.io/nano\"><path d=\"M63.9 65.6C81.7 65.6 96 51.2 96 33.4c0-17.6-14.4-32-32.1-32S32 15.9 32 33.6c0 17.6 14.3 32 31.9 32zm0-50.7c10.4 0 18.6 8.4 18.6 18.6 0 10.4-8.4 18.6-18.6 18.6s-18.6-8.4-18.6-18.6 8.4-18.6 18.6-18.6zm0 57.7C28.6 72.6 0 87 0 104.7v21.8h128v-21.8c0-17.7-28.8-32.1-64.1-32.1zm51.5 34.7v4.6c0 2-1.8 3.6-4 3.6H16.6c-2.2 0-4-1.6-4-3.6v-4.6-.6-.8c0-11.6 23-21 51.5-21 28.4 0 51.5 9.4 51.5 21v.8c-.2.4-.2.6-.2.6z\"/></svg>";
    }
}

using System;
using OpenCvSharp;

namespace SimpleWebApiClient
{
    public static class MatExtensions
    {
        public static void DrawRectangle(this Mat mat, Rect rect, Scalar color, Size controlSize)
        {
            var imageSize = mat.Size();

            var factor = ((float)controlSize.Width / imageSize.Width + (float)controlSize.Height / imageSize.Height) * 0.5;

            var thickness = (int)Math.Round(2.5 / factor);

            mat.Rectangle(rect, color, thickness, LineTypes.Link8);
        }
    }
}

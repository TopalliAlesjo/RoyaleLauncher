using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace RoyaleLauncher
{
    public static class ImageComparer
    {
        public static bool CompareImages(Image img1, Image img2)
        {
            if (img1 == null && img2 == null)
                return true;
            if (img1 == null || img2 == null)
                return false;

            using (MemoryStream ms1 = new MemoryStream())
            using (MemoryStream ms2 = new MemoryStream())
            {
                img1.Save(ms1, ImageFormat.Png);
                img2.Save(ms2, ImageFormat.Png);

                byte[] imgBytes1 = ms1.ToArray();
                byte[] imgBytes2 = ms2.ToArray();

                if (imgBytes1.Length != imgBytes2.Length)
                    return false;

                for (int i = 0; i < imgBytes1.Length; i++)
                {
                    if (imgBytes1[i] != imgBytes2[i])
                        return false;
                }

                return true;
            }
        }

        public static bool IsImageEqualToAny(Image img, params Image[] comparisonImages)
        {
            foreach (var comparisonImage in comparisonImages)
            {
                if (CompareImages(img, comparisonImage))
                    return true;
            }
            return false;
        }
    }
}

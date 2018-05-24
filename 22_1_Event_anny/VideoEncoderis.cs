using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_1_Event_anny
{
    class VideoEncoderis
    {

        // 1 - sukurti delegata
        public delegate void VideoEncodedEventHandler(object sender, EventArgs eventArgs);
        // 2 - sukurti ivyki pagal delegata
        public event VideoEncodedEventHandler VideoEncoded;
        // 3 - sugeneruoti ivyki
        protected virtual void OnVideoEncoded()
        {
            if(VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
        // vartotojo veiksmas, kuris sukuria ivyki
        public void Encode()
        {
            Console.WriteLine("Koduojam video");
            System.Threading.Thread.Sleep(3000);
            OnVideoEncoded();
        }
    }
}

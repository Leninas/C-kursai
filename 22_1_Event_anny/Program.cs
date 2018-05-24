using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_1_Event_anny
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoEncoderis videoEncoderis = new VideoEncoderis();
            MessageService messageService = new MessageService();
            videoEncoderis.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoderis.Encode();
        }
    }

    class MessageService // -aprasom kas bus padaryta ivykus ivykiui - soius sms
    {
        public void OnVideoEncoded(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("Messenge Service: ....");
        }
    }
}

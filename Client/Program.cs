using Generated;
using Grpc.Core;
using System;
using System.Globalization;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Host = "localhost";
            const int Port = 16842;

            var channel = new Channel($"{Host}:{Port}", ChannelCredentials.Insecure);
            var request = new HoroscopRequest();

            var WinterRequest = new WinterRequest();
            var SpringRequest = new SpringRequest();
            var SummerRequest = new SummerRequest();
            var AutumnRequest = new AutumnRequest();

            do
            {
                Console.WriteLine("Enter your Birthday: ");
                request.Date = Console.ReadLine();

            } while (isValid(request.Date) == false);

            //var client = new HoroscopService.HoroscopServiceClient(channel);
            //var respone = client.ShowSign(request);
            //Console.WriteLine("Your Zodiac Sign is {0} ", respone.Sign);

            //----------------------Bonus

            var Birthday = DateTime.Parse(request.Date);

            switch (wichSeasone(Birthday))
            {
                case 1:
                    var Springclient = new SpringService.SpringServiceClient(channel);
                    SpringRequest.Date = request.Date;
                    var respone1 = Springclient.getZodiacSign(SpringRequest);
                    Console.WriteLine("Your Zodiac Sign is {0} ", respone1.Sign);
                    break;

                case 2:
                    var Summerclient = new SummerService.SummerServiceClient(channel);
                    SummerRequest.Date = request.Date;
                    var respone3 = Summerclient.getZodiacSign(SummerRequest);
                    Console.WriteLine("Your Zodiac Sign is {0} ", respone3.Sign);
                    break;

                case 3:
                    var Autumnclient = new AutumnService.AutumnServiceClient(channel);
                    AutumnRequest.Date = request.Date;
                    var respone2 = Autumnclient.getZodiacSign(AutumnRequest);
                    Console.WriteLine("Your Zodiac Sign is {0} ", respone2.Sign);
                    break;

                case 4:
                    var Winterclient = new WinterService.WinterServiceClient(channel);
                    WinterRequest.Date = request.Date;
                    var respone4 = Winterclient.getZodiacSign(WinterRequest);
                    Console.WriteLine("Your Zodiac Sign is {0} ", respone4.Sign);
                    break;
            }

            // Shutdown
            channel.ShutdownAsync().Wait();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static bool isValid(string Date)
        {
            DateTime dateTime;

            if (DateTime.TryParseExact(Date, "MM/dd/yyyy", null, DateTimeStyles.None, out dateTime) == false)
            {
                Console.WriteLine("!!! INVALID DATE !!! \n");
                return false;
            }
            return true;
        }

        static int wichSeasone(DateTime Birthday)
        {
            if (Birthday.Month >= 03 && Birthday.Month <= 05)
            {
                Console.WriteLine("Your Zodiac Sign is a Spring Sign! ");
                return 1;
            }
            if (Birthday.Month >= 06 && Birthday.Month <= 08)
            {
                Console.WriteLine("Your Zodiac Sign is a Summer Sign! ");
                return 2;
            }
            if (Birthday.Month >= 09 && Birthday.Month <= 11)
            {
                Console.WriteLine("Your Zodiac Sign is a Autumn Sign! ");
                return 3;
            }
            if (Birthday.Month == 12 || Birthday.Month <= 2)
            {
                Console.WriteLine("Your Zodiac Sign is a Winter Sign! ");
                return 4;
            }

            return 0;
        }
    }
}

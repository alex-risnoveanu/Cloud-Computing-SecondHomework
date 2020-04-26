using Generated;
using Grpc.Core;
using System;
using System.Threading.Tasks;
using System.IO;

namespace Server
{
    internal class WinterService : Generated.WinterService.WinterServiceBase
    {
        public override Task<HoroscopResponse> getZodiacSign(WinterRequest request, ServerCallContext context)
        {
            var Birthday = DateTime.Parse(request.Date);

            string sign = "";
            string[] dates = File.ReadAllLines(@"../../WinterSigns.txt");

            for (int index = 0; index < dates.Length; index = index + 3)
            {
                sign = dates[index];
                var StartPeriod = DateTime.Parse(dates[index + 1]);
                var FinishPeriod = DateTime.Parse(dates[index + 2]);

                if (Birthday.Month == StartPeriod.Month && Birthday.Month == FinishPeriod.Month)
                {
                    if (Birthday.Day >= StartPeriod.Day && Birthday.Day <= FinishPeriod.Day)
                    {
                        break;
                    }
                }

                if (StartPeriod.Month != FinishPeriod.Month)
                {
                    if (Birthday.Month >= StartPeriod.Month && Birthday.Month <= FinishPeriod.Month)
                    {
                        if ((Birthday.Month == StartPeriod.Month && Birthday.Day >= StartPeriod.Day) || (Birthday.Month == FinishPeriod.Month && FinishPeriod.Day <= FinishPeriod.Day))
                        {
                            break;
                        }
                    }
                }
            }

            return Task.FromResult(new HoroscopResponse() { Sign = sign });
        }
    }
}

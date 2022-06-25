using System;

namespace Temperature_monitoring
{
    public class ProcessingInput
    {
        public string Recycle(string[] maxTemp, string[] minTemp, string[] rowDateTime, string rowTempList)
        {
            string report = "";

            string rowDate = rowDateTime[0];
            string rowTime = rowDateTime[1];

            string[] date_string = rowDate.Split('.');
            int[] date_int = new int[date_string.Length];
            for (int i = 0; i < date_string.Length; i++)
            {
                date_int[i] = Convert.ToInt32(date_string[i]);
            }

            string[] time_string = rowTime.Split(':');
            int[] time_int = new int[time_string.Length];
            for (int i = 0; i < time_string.Length; i++)
            {
                time_int[i] = Convert.ToInt32(time_string[i]);
            }
            int minuts = date_int[0] * 525600 + date_int[1] * 10080 + date_int[2] * 1440 + time_int[0] * 60 + time_int[1];

            string[] tempList = rowTempList.Split();

            bool haveMax = true;
            int max = new int();
            int maxTime = new int();
            if (maxTemp[0] != "")
            {
                max = Convert.ToInt32(maxTemp[0]);
                maxTime = Convert.ToInt32(maxTemp[1]);
            }
            else
            {
                haveMax = false;
            }

            bool haveMin = true;
            int min = new int();
            int minTime = new int();
            if (minTemp[0] != "")
            {
                min = Convert.ToInt32(maxTemp[0]);
                minTime = Convert.ToInt32(maxTemp[1]);
            }
            else
            {
                haveMin = false;
            }


            foreach (string temper in tempList)
            {
                int t = Convert.ToInt32(temper);

                if (haveMax == false)
                {
                    max = t;
                }
                if (haveMin == false)
                {
                    min = t;
                }

                if (t > max)
                {
                    report += WorkingOfDateTime(minuts);
                    int difference = Math.Abs(t - max);
                    report += ("|" + temper + "|" + ($"{max}") + "|" + $"{difference}");
                    report += "/";
                }
                else if (t < min)
                {
                    report += WorkingOfDateTime(minuts);
                    int difference = Math.Abs(t - min);
                    report += ("|" + temper + "|" + ($"{min}") + "|" + $"{difference}");
                    report += "/";
                }
                minuts += 10;
            }
            return report;
        }

        private string WorkingOfDateTime(int minuts)
        {
            int year = minuts / 525600;
            int week = (minuts % 525600) / 10080;
            int day = ((minuts % 525600) % 10080) / 1440;
            int hour = (((minuts % 525600) % 10080) % 1440) / 60;
            int minut = (((minuts % 525600) % 10080) % 1440) % 60;

            string answer = ($"{day}.{week}.{year} {hour}.{minut}");
            return answer;
        }
    }
}

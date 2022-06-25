using System;
using System.Windows.Forms;

namespace Temperature_monitoring
{
    public class ProcessingInput
    {
        static public string[] Recycle(string[] maxTemp, string[] minTemp, string rowDate, string rowTime, string rowTempList)
        {
            try
            {
                string report = "";

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
                int minuts = date_int[2] * 525600 + date_int[1] * 10080 + date_int[0] * 1440 + time_int[0] * 60 + time_int[1];

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
                    min = Convert.ToInt32(minTemp[0]);
                    minTime = Convert.ToInt32(minTemp[1]);
                }
                else
                {
                    haveMin = false;
                }

                if (max < min)
                {
                    return null;
                }


                int maxCounter = 0;
                int minCounter = 0;
                bool min_sensor = false; bool max_sensor = false;
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
                        maxCounter = maxCounter + 10;
                    }
                    else if (t < min)
                    {
                        report += WorkingOfDateTime(minuts);
                        int difference = Math.Abs(t - min);
                        report += ("|" + temper + "|" + ($"{min}") + "|" + $"{difference}");
                        report += "/";
                        minCounter = minCounter + 10;
                        min_sensor = true;
                    }
                    minuts += 10;
                }

                if (maxCounter > maxTime)
                {
                    max_sensor = true;
                }
                if (minCounter > minTime)
                {
                    min_sensor = true;
                }


                string[] unit_report = new string[4];
                unit_report[0] = report;
                unit_report[1] = Convert.ToString(maxCounter);
                unit_report[2] = Convert.ToString(minCounter);
                if (max_sensor == true)
                {
                    unit_report[3] = "Max";
                }
                else if (min_sensor == true)
                {
                    unit_report[3] = "Min";
                }
                else if (max_sensor == true && min_sensor == true)
                {
                    unit_report[3] = "MaxMin";
                }
                else if (max_sensor == false && min_sensor == false)
                {
                    unit_report[3] = "No";
                }

                return unit_report;
            }
            catch (Exception e){ return null; }

        }

        static private string WorkingOfDateTime(int minuts)
        {
            int year = minuts / 525600;
            int week = (minuts % 525600) / 10080;
            int day = ((minuts % 525600) % 10080) / 1440;
            int hour = (((minuts % 525600) % 10080) % 1440) / 60;
            int minut = (((minuts % 525600) % 10080) % 1440) % 60;

            string answer = ($"{day}.{week}.{year} {hour}:{minut}");
            return answer;
        }
    }
}

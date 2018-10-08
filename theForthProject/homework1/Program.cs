using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{

    public delegate void AlarmClockEventHandler(object sender, EventArgs e);


    public class EventArgs
    {
        public string ShowTime;
    }


    public class SetAlarmClock
    {
        public event AlarmClockEventHandler Setting;
        public void DoSetting()
        {
            Console.WriteLine("请输入闹钟唤醒时间(hh:mm)：");
            string str1 = Console.ReadLine();
            DateTime SettingTime;
            DateTime.TryParse(str1, out SettingTime);
            Console.WriteLine($"已设定闹钟为 {SettingTime}");

            DateTime NowTime = DateTime.Now;

            while (0 != DateTime.Compare(SettingTime, NowTime))
            {
                string str2 = DateTime.Now.ToShortTimeString().ToString();

                if (Setting != null)
                {
                    EventArgs args = new EventArgs();
                    args.ShowTime = str2;
                    if (str1 != str2)
                    {
                        Console.WriteLine("时间还没到，");
                    }
                    else
                    {
                        Console.WriteLine("时间到啦！");
                    }
                    Setting(this, args);
                }
            }
        }
    }

    public class UseAlarmClock
    {
        static void Main()
        {
            var setter = new SetAlarmClock();

            setter.Setting += ShowProgress;
            setter.DoSetting();
        }

        static void ShowProgress(object sender, EventArgs e)
        {
            Console.WriteLine($"当前时间为：{e.ShowTime: ##:##}");
        }
    }

}

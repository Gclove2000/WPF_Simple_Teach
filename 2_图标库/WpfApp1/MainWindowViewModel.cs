using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class MainWindowViewModel
    {

        public string Title { get; set; }

        public MyIcon Icon { get; set; }

        public List<MyIcon> IconList { get; set; }

        public MainWindowViewModel()
        {
            Title = "字符串搜索";
            Icon = new MyIcon()
            {
                Name = "对象搜索",
                IconCode = "&#xe645;",
                IconFont = "\ue645"
            };
            
            IconList = new List<MyIcon>()
            {
                new MyIcon()
                {
                    Name = "对象集合搜索",
                    IconCode = "&#xe645;",
                    IconFont = "\ue645"
                },
                new MyIcon()
                {
                    Name = "闹钟",
                    IconCode = "&#xe601;",
                    IconFont = "\ue601"
                },
                new MyIcon()
                {
                    Name = "日历",
                    IconCode = "&#xe65b;",
                    IconFont = "\ue65b"
                },
            };

        }
    }


    public class MyIcon
    {
        public string Name { get; set; }

        public string IconCode { get; set; }

        public string IconFont { get; set; }
    }
}

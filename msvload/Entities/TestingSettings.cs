using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msvload.Entities
{
    public class TestingSettings
    {
        public bool DefaultOrder { get; set; }
        public int HintCount { get; set; }
        public bool ShowRightAnswer { get; set; }

        public TestingSettings(bool defaultOrder, int hintCount, bool showRightAnswer)
        {
            DefaultOrder = defaultOrder;
            HintCount = hintCount;
            ShowRightAnswer = showRightAnswer;
        }

        public TestingSettings() { }
    }
}

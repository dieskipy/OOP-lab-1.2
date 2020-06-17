using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MusicLearning.InstrumentElements
{
    //все значения
    public enum InstrGroup
    {
        [Description("Духовые")]
        wind,
        [Description("Струнные")]
        strings,
        [Description("Клавишные")]
        keyboard
    }
    public class InstrumentAcccessoriesEl
    {
        //по дефолту при открытии формы
        public InstrGroup Group { get; set; } = InstrGroup.wind;
        public InstrumentAcccessoriesEl(InstrGroup type)
        {
            Group = type;
        }

    }
}

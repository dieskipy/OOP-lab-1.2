using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MusicLearning.InstrumentElements
{
    //все значения
    public enum ProfType
    {
        [Description("Новичок")]
        beginner,
        [Description("Любитель")]
        amateur,
        [Description("Продвинутый")]
        advanced,
        [Description("Профессионал")]
        professional
    }
    public class ProffessionalLevelEl
    {
        //по дефолту при открытии формы
        public ProfType Prof { get; set; } = ProfType.beginner;
        public ProffessionalLevelEl(ProfType type)
        {
            Prof = type;
        }
    }
}

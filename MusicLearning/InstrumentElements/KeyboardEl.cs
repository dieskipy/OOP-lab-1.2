using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MusicLearning.InstrumentElements
{
    //все значения
    public enum KeyboardType
    {
        [Description("Рояль")]
        grpiano,
        [Description("Пианино")]
        piano,
        [Description("Синтезатор")]
        synthesizer,
        [Description("Цифровое пианино")]
        digpiano
    }

    public class KeyboardEl
    {
        //по дефолту при открытии формы
        public KeyboardType Keyboard { get; set; } = KeyboardType.grpiano;
        public KeyboardEl(KeyboardType type)
        {
            Keyboard = type;
        }

    }
}

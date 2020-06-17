using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MusicLearning.InstrumentElements
{
    //все значения
    public enum Lesson
    {
        [Description("Консультация")]
        consultation,
        [Description("Обучение")]
        training
    }
    public class LessonTypeEl
    {
        //по дефолту при открытии формы
        public Lesson Lesson { get; set; } = Lesson.consultation;
        public LessonTypeEl(Lesson type)
        {
            Lesson = type;
        }
    }
}

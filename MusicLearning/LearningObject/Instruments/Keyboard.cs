using MusicLearning.Attributes;
using MusicLearning.InstrumentElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MusicLearning.LearningObject.Instruments
{
    //для связки класс - дисплей класса
    [ProductType("Клавишные инструменты")]
    public class Keyboard:Instrument
    {
        //связанные значения для комбо бокса
        public KeyboardEl KeyboardName { set; get; }
        public Keyboard()
        {
            //общение с тичер еще до открытия формы
            TeacherInfo = new Teacher();
        }
    }
}

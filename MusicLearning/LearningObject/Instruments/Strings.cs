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
    [ProductType("Струнные инструменты")]
    public class Strings:Instrument
    {
        //связанные значения для комбо бокса
        public StringsEl StringsName { set; get; }
        public Strings()
        {
            //общение с тичер еще до открытия формы
            TeacherInfo = new Teacher();
        }
    }
}

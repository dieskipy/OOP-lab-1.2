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
    [ProductType("Духовые инструменты")]
    public class Wind:Instrument
    {
        //связанные значения для комбо бокса
        public WindEl WindName { set; get; }

        public Wind()
        {
            //общение с тичер еще до открытия формы
            TeacherInfo = new Teacher();
        }
    }
}

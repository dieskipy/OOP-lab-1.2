using MusicLearning.Attributes;
using MusicLearning.InstrumentElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MusicLearning.LearningObject.Accessories
{
    //для связки класс - дисплей класса
    [ProductType("Инструментальные аксессуары")]
    public class InstrumentAccessories:Accessory
    {
        //связанные значения для комбо бокса
        public InstrumentAcccessoriesEl InstrAcGroup { set; get; }
        public InstrumentAccessories()
        {
            //общение с тичер еще до открытия формы
            TeacherInfo = new Teacher();
        }
    }
}

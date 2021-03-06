﻿using MusicLearning.InstrumentElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLearning.LearningObject
{
    abstract public class PersonalService
    {
        public string CourseName { get; set; }
        //ассоциация-класс
        public Teacher TeacherInfo { get; set; }
        //дефолт для даты
        public DateTime Data { get; set; } = DateTime.Now;
    }
}

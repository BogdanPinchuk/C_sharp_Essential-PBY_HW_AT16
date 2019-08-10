﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Int32 MaxValue = 2147_48_36_47;
// рік 4, місяць 2, день 2, година 2, а хвилини 2 - не поміщаються, помилка умови
// для цього треба тип long, а метод GetHashCode працює лише з int

namespace LesApp0
{
    class TestClass2
    {
        /// <summary>
        /// Змінна для hashcode, щоб не мінялась при кожному виклику методу
        /// </summary>
        private readonly int hashCode;

        /// <summary>
        /// Конструктор, який тільки раз створює hashcode
        /// </summary>
        public TestClass2()
        {
            hashCode = CalcHashCode();
        }

        public override int GetHashCode()
            => hashCode;

        public override bool Equals(object obj)
        {
            if (obj == null ||
                GetType() != obj.GetType())
            {
                return false;
            }

            // кастинг
            TestClass2 temp = obj as TestClass2;

            return temp == this;
        }

        /// <summary>
        /// Метод отримання унікального hashcode
        /// </summary>
        /// <returns></returns>
        private int CalcHashCode()
            => new Random().Next(int.MinValue, int.MaxValue);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomLibrary
{
    public class Room
    {
        double roomLenght; // длина комнаты
        double roomWidth; // ширина комнаты  

        public double RoomLenght
        {
            get { return roomLenght; }
            set { roomLenght = value; }
        }

        public double RoomWidth
        {
            get { return roomWidth; }
            set { roomWidth = value; }
        }

        /// <summary>
        /// метод вычисляет периметр комнаты
        /// </summary>
        /// <returns></returns>
        public double RoomPerimeter()
        {
            return 2 * (roomLenght * roomLenght);
        } 

        /// <summary>
        /// Метод вычисляет площадь комнаты 
        /// </summary>
        /// <returns></returns>
        public double RoomArea()
        {
            return roomWidth * roomLenght;
        }
  
        /// <summary>
        /// Метод вычисляет число квадратных метров на одного человека
        /// </summary>
        /// <param name="np">Число человек</param>
        /// <returns> возвращает число квадратных метров </returns>
        public double PersonArea(int np)
        {
            return RoomArea();
        }

    }
}
  
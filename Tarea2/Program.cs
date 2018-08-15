using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2 {
    class Program {
        static void Main(string[] args) {
            Enemy soldier = new Enemy();
            soldier.XPosition = 0;
            soldier.YPosition = 0;
            soldier.KillPoints = 0;

            Console.WriteLine("El enemigo esta en la posición "
                              + soldier.XPosition + ", " + soldier.YPosition);
            Console.WriteLine("Matar a este enemigo otorga " + soldier.KillPoints + " puntos");

            soldier.move(10, -3);
            Console.WriteLine("Ahora el enemigo esta en la posición "
                              + soldier.XPosition + ", " + soldier.YPosition);
            soldier.move(-3, 46);
            Console.WriteLine("Ahora el enemigo esta en la posición "
                              + soldier.XPosition + ", " + soldier.YPosition);
            soldier.shoot();
            soldier.explode();

            Console.ReadKey();
        }
    }
}

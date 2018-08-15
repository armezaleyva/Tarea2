using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2 {
    class Enemy {
        public int XPosition { get; set; }
        public int YPosition { get; set; }

        private int _killPoints;
        public int KillPoints {
            get {
                return _killPoints;
            } set {
                if (value >= 100) {
                    _killPoints = value;
                } else {
                    _killPoints = 100;
                }
            }
        }

        public void move(int xMovement, int yMovement) {
            XPosition += xMovement;
            YPosition += yMovement;
        }

        public void shoot() {
            Console.WriteLine("Pew pew");
        }

        public void explode() {
            Console.WriteLine("Boom");
        }
    }
}

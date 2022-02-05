using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    public class Knight : Character
    {
        public Knight()
        {
            this.Weapon = new SwordBehaviour();
        }
    }
}

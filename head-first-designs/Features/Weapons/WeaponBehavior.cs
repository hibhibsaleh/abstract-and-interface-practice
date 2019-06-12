using System;
using System.Collections.Generic;
using System.Text;

namespace head_first_designs.Features.Weapons
{
    // interfaces are not classes, they are entities
    // contract that enforces hierarchies
    public interface IWeaponBehavior
    {
        // no implementation, has signature or definition of method w/o body
        int GetDamage();
    }

    // classes can inherit multiple interfaces, not just one (vs abstract classes)
    public class Axe : IWeaponBehavior
    {
        public int GetDamage()
        {
            return 2;
        }
    }

    public class Sword : IWeaponBehavior
    {
        public int GetDamage()
        {
            return 4;
        }
    }

    public class Hammer : IWeaponBehavior
    {
        public int GetDamage()
        {
            return 8;
        }
    }

    public class BowAndArrow : IWeaponBehavior
    {
        public int GetDamage()
        {
            return 6;
        }
    }
}

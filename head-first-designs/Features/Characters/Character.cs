using head_first_designs.Features.Weapons;
using System;
using System.Collections.Generic;
using System.Text;

namespace head_first_designs.Features.Characters
{
    // special class that cannot be instantiated but other classes can inherit from it
    // contract that enforces hierarchies for all subclasses
    public abstract class Character
    {
        // protected - can be inherited by all classes child classes
        // readonly - cannot be edited by anyone/thing else
        protected readonly IWeaponBehavior _weaponBehavior;

        public Character(IWeaponBehavior weaponBehavior)
        {
            _weaponBehavior = weaponBehavior;
        }

        // abstract methods have signature only, no body
        public abstract int Fight();
        
        // virtual methods may or may not have bodies
        //public virtual int Fight()
        //{
        //}
    }

    // inherits from Character class
    // can only inherit from one class, no more
    public class Warrior : Character
    {
        public Warrior(IWeaponBehavior weaponBehavior) :
            base(weaponBehavior)
        {
        }

        // must use body in child class method to assign action for method
        public override int Fight()
        {
            return 5 + _weaponBehavior.GetDamage();
        }
    }

    public class Knight : Character
    {
        public Knight(IWeaponBehavior weaponBehavior) :
            base(weaponBehavior)
        {
        }
        // "base" is parent class

        public override int Fight()
        {
            return 4 + _weaponBehavior.GetDamage();
        }
    }

    public class Queen : Character
    {
        public Queen(IWeaponBehavior weaponBehavior) :
            base(weaponBehavior)
        {
        }

        public override int Fight()
        {
            return 10 * _weaponBehavior.GetDamage();
        }
    }

    public class King : Character
    {
        public King(IWeaponBehavior weaponBehavior) :
            base(weaponBehavior)
        {
        }

        public override int Fight()
        {
            return 10 + _weaponBehavior.GetDamage();
        }
    }
}

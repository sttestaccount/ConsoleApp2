using System;
namespace maandag
{
    public static class Character
    {
        private int currentHP { get; set; }

        public static void TakeDamage(int Instance, int damageAmount)
        {
            instance.CurrentHP = instance.CurrentHP - damageAmount;
        }
    }

}

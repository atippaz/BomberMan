using System;

namespace BomberMan
{
    class CharacterMove : CharacterBase
    {
        #region Methods
        public virtual void Move(string directions)
        {
            Console.WriteLine("Don't Forget Implement This Move Method in Character Class");
        }
        #endregion
    }
}

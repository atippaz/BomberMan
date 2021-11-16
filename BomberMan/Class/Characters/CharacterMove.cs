using System;

namespace BomberMan
{
    class CharacterMove :CharacterBehavior
    {
        public bool WalkFinish = true;
        public string DirectionPlayer;
        #region Methods
        public virtual void Move(string directions)
        {
            Console.WriteLine("Don't Forget Implement This Move Method in Character Class");
        }
        #endregion
    }
}

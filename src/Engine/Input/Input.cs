using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;

namespace StoryForgeEngine
{
    public class Input
    {
        protected KeyboardState _newKeyboard, _oldKeyboard;
        protected List<Keys> _pressedKeys, _previouslyPressedKeys;

        public Input()
        {
            _pressedKeys = new List<Keys>();
            _previouslyPressedKeys = new List<Keys>();
        }

        public virtual void Update()
        {
            _newKeyboard = Keyboard.GetState();
            GetPressedKeys();
        }

        public virtual void UpdateOld()
        {
            for(int i=0;i<_pressedKeys.Count;i++)
            {
                _previouslyPressedKeys.Add(_pressedKeys[i]);
            }
        }

        public virtual void GetPressedKeys()
        {
            _pressedKeys.Clear();

            for (int i = 0; i < _newKeyboard.GetPressedKeys().Length; i++)
            {
                _pressedKeys.Add(_newKeyboard.GetPressedKeys()[i]);
            }
        }

        public virtual bool GetKeyDown(Keys key)
        {
            if (_pressedKeys.Contains(key))
            {
                return true;
            }
            return false;
        }
    }
}

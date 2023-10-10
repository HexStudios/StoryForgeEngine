using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace StoryForgeEngine
{
    public class Input
    {
        protected KeyboardState _currentState, _previousState;
        protected List<Keys> _pressedKeys;

        public Input()
        {
            _pressedKeys = new List<Keys>();
        }

        public virtual void Update(GameTime gameTime)
        {
            _currentState = Keyboard.GetState();
        }

        public virtual KeyboardState GetState()
        {
            _previousState = _currentState;
            _currentState = Keyboard.GetState();
            return _currentState;
        }

        public virtual bool GetKeyDown(Keys key)
        {
            return _currentState.IsKeyDown(key);
        }

        public virtual bool WasKeyJustPressed(Keys key)
        {
            GetState();
            return _currentState.IsKeyDown(key) && _previousState.IsKeyUp(key);
        }

    }
}

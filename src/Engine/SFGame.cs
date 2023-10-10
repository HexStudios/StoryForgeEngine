using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace StoryForgeEngine
{
    public class SFGame
    {
        protected string _name;
        protected List<Behavior> _behaviors;

        public SFGame(string name)
        {
            _name = name;

            _behaviors = new List<Behavior>();
        }

        public virtual void Initialize()
        {
        }

        public virtual void Update(GameTime gameTime)
        {
            if (_behaviors is null || _behaviors.Count == 0)
            {
                return;
            }
            foreach (Behavior behavior in _behaviors)
            {
                behavior.Update(gameTime);
            }
        }

        public virtual void Draw(GameTime gameTime)
        {
            if (_behaviors is null || _behaviors.Count == 0)
            {
                return;
            }
            foreach (Behavior behavior in _behaviors)
            {
                behavior.Draw(gameTime);
            }
        }

        protected void AddBehavior(Behavior behavior)
        {
            if (behavior == null)
            {
                throw new Exception("Cannot add a null behaviour");
            }
            _behaviors.Add(behavior);
            behavior.Initialize();
        }

        protected void RemoveBehavior(Behavior behavior)
        {
            if (_behaviors.Count != 0 && _behaviors.Contains(behavior))
            {
                _behaviors.Remove(behavior);
            }
            else 
            {
                throw new Exception($"Cannot remove {behavior} from list as it does not exist.");
            }
        }
    }
}
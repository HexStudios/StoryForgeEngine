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
        public List<Entity> Entities;

        public List<string> CollisionLayers;

        public SFGame(string name)
        {
            _name = name;

            Entities = new List<Entity>();
        }

        public virtual void Initialize()
        {
        }

        public virtual void Update(GameTime gameTime)
        {
            if (Entities is null || Entities.Count == 0)
            {
                return;
            }
            foreach (Entity behavior in Entities)
            {
                behavior.Update(gameTime);
            }
        }

        public virtual void Draw(GameTime gameTime)
        {
            if (Entities is null || Entities.Count == 0)
            {
                return;
            }
            foreach (Entity behavior in Entities)
            {
                behavior.Draw(gameTime);
            }
        }

        public void AddEntity(Entity behavior)
        {
            if (behavior == null)
            {
                throw new Exception("Cannot add a null Entity");
            }
            Entities.Add(behavior);
            behavior.Initialize();
        }

        public void RemoveEntity(Entity entity)
        {
            if (Entities.Count != 0 && Entities.Contains(entity))
            {
                Entities.Remove(entity);
            }
            else 
            {
                SFEngine.PrintError($"Trying to remove a {entity}({entity.Name}) from {_name} Entity List that does not exist.");
            }
        }
    }
}

using Microsoft.Xna.Framework;

namespace StoryForgeEngine
{
    public class Entity
    {

        public string Name;
        public Entity()
        {
        }

        public virtual void Initialize()
        {
            if (Name is null)
            {
                Name = this.ToString();
            }
        }

        public virtual void Update(GameTime gameTime)
        {

        }

        public virtual void Draw(GameTime gameTime)
        {

        }
    }
}

using Microsoft.Xna.Framework;

namespace StoryForgeEngine
{
    public class Behavior
    {

        public string Name;
        public Behavior()
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
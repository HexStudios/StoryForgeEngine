using Microsoft.Xna.Framework;
using static StoryForgeEngine.EngineGlobals;

namespace StoryForgeEngine
{
    public class Player : Sprite2D
    {
        protected float speed = 5f;

        public Player(string texturePath, Vector2 position, float rotation, Vector2 dimensions) : base(texturePath, position, rotation, dimensions)
        {
        }

        public override void Initialize()
        {
            
            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            HandleMovement();
            HandleCollision();
            base.Update(gameTime);

            Position += Velocity;
            Velocity = Vector2.Zero;
        }

        private void HandleMovement()
        {
            if (GlobalInputManager.GetKeyDown(Keybinds.LEFT))
            {
                Velocity.X = -speed;
            }
            if (GlobalInputManager.GetKeyDown(Keybinds.RIGHT))
            {
                Velocity.X = speed;
            }
            if (GlobalInputManager.GetKeyDown(Keybinds.UP))
            {
                Velocity.Y = -speed;
            }
            if (GlobalInputManager.GetKeyDown(Keybinds.DOWN))
            {
                Velocity.Y = speed;
            }
        }

        private void HandleCollision()
        {
            foreach (Sprite2D sprite in CurrentGame.Entities)
            {
                
                if (sprite == this)
                {
                    continue;
                }
                
                if (sprite.CollisionLayer == Collision.Layers.Floor)
                {
                    if (Velocity.X > 0 && IsCollidingLeft(sprite) || Velocity.X < 0 && IsCollidingRight(sprite))
                    {
                        Velocity.X = 0;
                    }
                    if (Velocity.Y > 0 && IsCollidingTop(sprite) || Velocity.Y < 0 && IsCollidingBottom(sprite))
                    {
                        Velocity.Y = 0;
                    }
                }
            }
            
        }
    }
}
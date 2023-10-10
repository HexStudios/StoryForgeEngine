using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StoryForgeEngine
{
    public class Sprite2D : Entity
    {
        public bool HasGravity = false;
        public Collision.Layers CollisionLayer = Collision.Layers.Default;
        public Vector2 Position, Dimensions, Velocity;
        public float Rotation;
        public Color Color = Color.White;
        public Texture2D Texture;

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            if (Texture != null)
            {
                EngineGlobals.GlobalSpriteBatch.Draw(Texture, Rect, null, Color, Rotation, new Vector2(Texture.Bounds.Width/2, Texture.Bounds.Height/2), new SpriteEffects(), 0);
            }
            base.Draw(gameTime);
        }

        public Sprite2D(string texturePath, Vector2 position, float rotation, Vector2 dimensions)
        {
            Texture = EngineGlobals.GlobalContentManager.Load<Texture2D>(texturePath);

            Position = position;
            Rotation = rotation;
            Dimensions = dimensions;

            Name = Texture.Name;
        }

        public Rectangle Rect
        {
            get 
            {
                if (Texture != null)
                {
                    return new Rectangle((int)Position.X, (int)Position.Y, Texture.Width, Texture.Height);
                }

                throw new Exception($"No texture found.");
            }
        }

        // COLLISION
        public bool IsCollidingLeft(Sprite2D sprite)
        {
            return this.Rect.Right + this.Velocity.X > sprite.Rect.Left &&
                    this.Rect.Left < sprite.Rect.Left &&
                    this.Rect.Bottom > sprite.Rect.Top &&
                    this.Rect.Top < sprite.Rect.Bottom;
        }
        public bool IsCollidingRight(Sprite2D sprite)
        {
            return this.Rect.Left + this.Velocity.X < sprite.Rect.Right &&
                    this.Rect.Right > sprite.Rect.Right &&
                    this.Rect.Bottom > sprite.Rect.Top &&
                    this.Rect.Top < sprite.Rect.Bottom;
        }
        public bool IsCollidingTop(Sprite2D sprite)
        {
            return this.Rect.Bottom + this.Velocity.Y > sprite.Rect.Top &&
                    this.Rect.Top < sprite.Rect.Top &&
                    this.Rect.Right > sprite.Rect.Left &&
                    this.Rect.Left < sprite.Rect.Right;
        }
        public bool IsCollidingBottom(Sprite2D sprite)
        {
            return this.Rect.Top + this.Velocity.Y < sprite.Rect.Bottom &&
                    this.Rect.Bottom > sprite.Rect.Bottom &&
                    this.Rect.Right > sprite.Rect.Left &&
                    this.Rect.Left < sprite.Rect.Right;
        }

        public bool IsColliding(Sprite2D sprite)
        {
            return IsCollidingLeft(sprite) || IsCollidingRight(sprite) || IsCollidingTop(sprite) || IsCollidingBottom(sprite);
        }
    }
}
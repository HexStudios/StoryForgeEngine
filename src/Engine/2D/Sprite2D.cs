using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StoryForgeEngine
{
    public class Sprite2D : Behavior
    {

        private Vector2 _position, _dimensions;
        private float _rotation;
        private Color _color = Color.White;
        private Texture2D _texture;
        public Texture2D Texture
        {
            get => _texture;
            set => _texture = value;
        }
        public float Rotation
        {
            get => _rotation;
            set => _rotation = value;
        }
        public Vector2 Position
        {
            get => _position;
            set => _position = value;
        }
        public Vector2 Dimensions
        {
            get => _dimensions;
            set => _dimensions = value;
        }

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
            if (_texture != null)
            {
                EngineGlobals.GlobalSpriteBatch.Draw(_texture, Rect, null, _color, _rotation, new Vector2(_texture.Bounds.Width/2, _texture.Bounds.Height/2), new SpriteEffects(), 0);
            }
            base.Draw(gameTime);
        }

        public Sprite2D(string texturePath, Vector2 position, float rotation, Vector2 dimensions)
        {
            _texture = EngineGlobals.GlobalContentManager.Load<Texture2D>(texturePath);

            Position = position;
            Rotation = rotation;
            Dimensions = dimensions;
        }

        public Rectangle Rect
        {
            get 
            {
                if (_texture != null)
                {
                    return new Rectangle((int)_position.X, (int)_position.Y, _texture.Width, _texture.Height);
                }
                throw new Exception($"No texture found.");
            }
        }
    }
}
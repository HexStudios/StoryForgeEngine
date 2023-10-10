using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace StoryForgeEngine
{
    class MySFGame : SFGame
    {

        Sprite2D sprite;
        Player player;

        public MySFGame(string name) : base(name)
        {
            _name = "MySFGame";
        }

        public override void Initialize()
        {
            sprite = new Sprite2D("2D\\sleezebag", new Vector2(100,100), 0f, new Vector2(16,16))
            {
                CollisionLayer = Collision.Layers.Enemy
            };

            player = new Player("2D\\sleezebag", new Vector2(300, 300), 0, new Vector2(16, 16))
            {
                Color = Color.Blue, 
                CollisionLayer = Collision.Layers.Player
            };

            AddEntity(sprite);
            AddEntity(player);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
    }
}
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace StoryForgeEngine
{
    class MySFGame : SFGame
    {

        Sprite2D sprite;

        public MySFGame(string name) : base(name)
        {
            _name = "MySFGame";
        }

        public override void Initialize()
        {
            sprite = new Sprite2D("2D\\sleezebag", new Vector2(100,100), 0f, new Vector2(16,16));
            AddToGame(sprite);
        }

        public override void Update(GameTime gameTime)
        {
            if (EngineGlobals.GlobalInputManager.WasKeyJustPressed(Keybinds.JUMP))
            {
                RemoveFromGame(sprite);
            }
            base.Update(gameTime);
        }
    }
}
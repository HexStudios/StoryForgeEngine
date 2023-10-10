using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace StoryForgeEngine;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SFGame game;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        
        base.Initialize();
    }

    protected override void LoadContent()
    {
        EngineGlobals.GlobalSpriteBatch = new SpriteBatch(GraphicsDevice);
        EngineGlobals.GlobalContentManager = this.Content;
        EngineGlobals.GlobalInputManager = new Input();

        game = new MySFGame("MySFGame");
        game.Initialize();
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        game.Update(gameTime);
        EngineGlobals.GlobalInputManager.Update(gameTime);
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);
        EngineGlobals.GlobalSpriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend);

        game.Draw(gameTime);

        EngineGlobals.GlobalSpriteBatch.End();
        base.Draw(gameTime);
    }

    public static void Main()
    {
        using var game = new Game1();
        game.Run();
    }
}

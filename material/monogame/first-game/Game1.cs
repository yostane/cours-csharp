using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace first_game;

public class Game1 : Game
{
  private Rectangle _player;
  private bool _isDead = false;
  private Rectangle[] _goombas = {
    new(200, 70, 30, 30),
    new(410, 70, 30, 30),
    new(500, 130, 30, 30),
  };
  private Texture2D _playerTexture, _goombaTexture, _playerDeadTexture;
  private GraphicsDeviceManager _graphics;
  private SpriteBatch _spriteBatch;

  public Game1()
  {
    _graphics = new GraphicsDeviceManager(this);
    Content.RootDirectory = "Content";
    IsMouseVisible = true;
    _player = new(50, 50, 30, 70);
  }

  protected override void Initialize()
  {
    // TODO: Add your initialization logic here

    base.Initialize();
  }

  protected override void LoadContent()
  {
    _spriteBatch = new SpriteBatch(GraphicsDevice);
    _playerTexture = Content.Load<Texture2D>("mario-pose-1");
    _goombaTexture = Content.Load<Texture2D>("goomba-pose-1");
    _playerDeadTexture = Content.Load<Texture2D>("mario-pose-mort");
  }

  protected override void Update(GameTime gameTime)
  {
    if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
      Exit();

    if (GamePad.GetState(PlayerIndex.One).DPad.Left == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Left))
      _player.X -= 3;
    else if (GamePad.GetState(PlayerIndex.One).DPad.Right == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Right))
      _player.X += 3;

    if (GamePad.GetState(PlayerIndex.One).DPad.Down == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Down))
      _player.Y += 3;
    else if (GamePad.GetState(PlayerIndex.One).DPad.Up == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Up))
      _player.Y -= 3;

    _isDead = false;
    foreach (var goomba in _goombas)
    {
      if (_player.Intersects(goomba))
      {
        _isDead = true;
        break;
      }
    }

    base.Update(gameTime);
  }

  protected override void Draw(GameTime gameTime)
  {
    GraphicsDevice.Clear(Color.CornflowerBlue);

    _spriteBatch.Begin();
    _spriteBatch.Draw(_isDead ? _playerDeadTexture : _playerTexture, this._player, Color.White);
    foreach (var goomba in _goombas)
    {
      _spriteBatch.Draw(_goombaTexture, goomba, Color.White);
    }
    _spriteBatch.End();
    base.Draw(gameTime);
  }
}

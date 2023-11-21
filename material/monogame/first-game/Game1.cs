using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace first_game;

public class Game1 : Game
{
  private Rectangle _player, _map;
  private bool _isDead = false;
  private Rectangle[] _goombas = {
    new(200, 70, 30, 30),
    new(410, 70, 30, 30),
    new(500, 130, 30, 30),
  };
  private Texture2D _playerTexture, _goombaTexture, _playerDeadTexture, _bg1CollisionTexture, _bg1Texture;
  private Color[] _mapCollisionColors;
  private GraphicsDeviceManager _graphics;
  private SpriteBatch _spriteBatch;

  private Song _mainMusic;

  public Game1()
  {
    _graphics = new GraphicsDeviceManager(this);
    Content.RootDirectory = "Content";
    IsMouseVisible = true;
    _player = new(50, 50, 30, 70);
    _map = new(0, 0, 709, 278);
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
    _bg1CollisionTexture = Content.Load<Texture2D>("level1-collisions");
    _mapCollisionColors = new Color[_bg1CollisionTexture.Width * _bg1CollisionTexture.Height];
    _bg1CollisionTexture.GetData<Color>(_mapCollisionColors);
    _bg1Texture = Content.Load<Texture2D>("level1-map");
    _mainMusic = Content.Load<Song>("music");
    MediaPlayer.Play(_mainMusic);
    MediaPlayer.IsRepeating = true;
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
    _spriteBatch.Draw(_bg1Texture, _map, Color.White);
    _spriteBatch.End();
    base.Draw(gameTime);
  }
}

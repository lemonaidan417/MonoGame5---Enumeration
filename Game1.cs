using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace MonoGame5___Enumeration
{
    enum Screen
    {
        Intro,
        MainAnimation
    }
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D backgroundIntroTexture;
        Texture2D brownTribbleTexture;
        Texture2D creamTribbleTexture;
        Texture2D greyTribbleTexture;
        Texture2D orangeTribbleTexture;
        Texture2D backgroundTexture;

        Rectangle brownTribbleRect;
        Rectangle creamTribbleRect;
        Rectangle greyTribbleRect;
        Rectangle orangeTribbleRect;
        Rectangle window;

        Vector2 brownTribbleSpeed;
        Vector2 creamTribbleSpeed;
        Vector2 greyTribbleSpeed;
        Vector2 orangeTribbleSpeed;

        Color brownTribbleColor;
        Color creamTribbleColor;
        Color greyTribbleColor;
        Color orangeTribbleColor;

        MouseState mouseState;

        Random random = new Random();

        Screen screen;

        int numColors;
        int bounces = 0;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            window = new Rectangle(0, 0, 800, 480);
            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;


            brownTribbleRect = new Rectangle(random.Next(0, window.Width - 100), random.Next(0, window.Height - 100), 100, 100);
            brownTribbleSpeed = new Vector2(0, 25);
            brownTribbleColor = Color.White;

            creamTribbleRect = new Rectangle(random.Next(0, window.Width - 100), random.Next(0, window.Height - 100), 100, 100);
            creamTribbleSpeed = new Vector2(25, 0);
            creamTribbleColor = Color.White;

            greyTribbleRect = new Rectangle(random.Next(0, window.Width - 100), random.Next(0, window.Height - 100), 100, 100);
            greyTribbleSpeed = new Vector2(15, 2);
            greyTribbleColor = Color.White;

            orangeTribbleRect = new Rectangle(random.Next(0, window.Width - 100), random.Next(0, window.Height - 100), 100, 100);
            orangeTribbleSpeed = new Vector2(8, 15);
            orangeTribbleColor = Color.White;

            screen = Screen.Intro;
            base.Initialize();

        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            backgroundTexture = Content.Load<Texture2D>("space-background");
            brownTribbleTexture = Content.Load<Texture2D>("tribbleBrown");
            creamTribbleTexture = Content.Load<Texture2D>("tribbleCream");
            greyTribbleTexture = Content.Load<Texture2D>("tribbleGrey");
            orangeTribbleTexture = Content.Load<Texture2D>("tribbleOrange");
            backgroundIntroTexture = Content.Load<Texture2D>("background");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            mouseState = Mouse.GetState();

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            if (screen == Screen.Intro)
            {
                if (mouseState.LeftButton == ButtonState.Pressed)
                {
                    screen = Screen.MainAnimation;
                }
            }
            else if (screen == Screen.MainAnimation)
            {
                {
                    // Left n Right
                    brownTribbleRect.X += (int)brownTribbleSpeed.X;
                    if (brownTribbleRect.Right > window.Width || brownTribbleRect.Left < 0)
                    {
                        bounces++;
                        brownTribbleSpeed.X *= -1;
                    }

                    // Up n Down
                    brownTribbleRect.Y += (int)brownTribbleSpeed.Y;
                    if (brownTribbleRect.Top < 0 || brownTribbleRect.Bottom > window.Height)
                    {
                        bounces++;
                        brownTribbleSpeed.Y *= -1;

                        numColors = random.Next(0, 5);

                        if (numColors == 0)
                        {
                            brownTribbleColor = Color.White;
                        }
                        else if (numColors == 1)
                        {
                            brownTribbleColor = Color.Red;
                        }
                        else if (numColors == 2)
                        {
                            brownTribbleColor = Color.Yellow;
                        }
                        else if (numColors == 3)
                        {
                            brownTribbleColor = Color.Green;
                        }
                        else if (numColors == 4)
                        {
                            brownTribbleColor = Color.Blue;
                        }
                    }


                } // Brown Tribble
                {
                    // Left n Right
                    creamTribbleRect.X += (int)creamTribbleSpeed.X;
                    if (creamTribbleRect.Right > window.Width || creamTribbleRect.Left < 0)
                    {
                        bounces++;
                        creamTribbleSpeed.X *= -1;

                        numColors = random.Next(0, 5);

                        if (numColors == 0)
                        {
                            creamTribbleColor = Color.White;
                        }
                        else if (numColors == 1)
                        {
                            creamTribbleColor = Color.Red;
                        }
                        else if (numColors == 2)
                        {
                            creamTribbleColor = Color.Yellow;
                        }
                        else if (numColors == 3)
                        {
                            creamTribbleColor = Color.Green;
                        }
                        else if (numColors == 4)
                        {
                            creamTribbleColor = Color.Blue;
                        }
                    }

                    // Up n Down
                    creamTribbleRect.Y += (int)creamTribbleSpeed.Y;
                    if (creamTribbleRect.Top < 0 || creamTribbleRect.Bottom > window.Height)
                    {
                        bounces++;
                        creamTribbleSpeed.Y *= -1;
                    }
                } // Cream Tribble
                {
                    // Left n Right
                    greyTribbleRect.X += (int)greyTribbleSpeed.X;
                    if (greyTribbleRect.Right > window.Width || greyTribbleRect.Left < 0)
                    {
                        bounces++;
                        greyTribbleSpeed.X *= -1;

                        numColors = random.Next(0, 5);

                        if (numColors == 0)
                        {
                            greyTribbleColor = Color.White;
                        }
                        else if (numColors == 1)
                        {
                            greyTribbleColor = Color.Red;
                        }
                        else if (numColors == 2)
                        {
                            greyTribbleColor = Color.Yellow;
                        }
                        else if (numColors == 3)
                        {
                            greyTribbleColor = Color.Green;
                        }
                        else if (numColors == 4)
                        {
                            greyTribbleColor = Color.Blue;
                        }
                    }

                    // Up n Down
                    greyTribbleRect.Y += (int)greyTribbleSpeed.Y;
                    if (greyTribbleRect.Top < 0 || greyTribbleRect.Bottom > window.Height)
                    {
                        bounces++;
                        greyTribbleSpeed.Y *= -1;

                        numColors = random.Next(0, 5);

                        if (numColors == 0)
                        {
                            greyTribbleColor = Color.White;
                        }
                        else if (numColors == 1)
                        {
                            greyTribbleColor = Color.Red;
                        }
                        else if (numColors == 2)
                        {
                            greyTribbleColor = Color.Yellow;
                        }
                        else if (numColors == 3)
                        {
                            greyTribbleColor = Color.Green;
                        }
                        else if (numColors == 4)
                        {
                            greyTribbleColor = Color.Blue;
                        }
                    }
                } // Grey Tribble
                {
                    // Left n Right
                    orangeTribbleRect.X += (int)orangeTribbleSpeed.X;
                    if (orangeTribbleRect.Right > window.Width || orangeTribbleRect.Left < 0)
                    {
                        bounces++;
                        orangeTribbleSpeed.X *= -1;

                        numColors = random.Next(0, 5);

                        if (numColors == 0)
                        {
                            orangeTribbleColor = Color.White;
                        }
                        else if (numColors == 1)
                        {
                            orangeTribbleColor = Color.Red;
                        }
                        else if (numColors == 2)
                        {
                            orangeTribbleColor = Color.Yellow;
                        }
                        else if (numColors == 3)
                        {
                            orangeTribbleColor = Color.Green;
                        }
                        else if (numColors == 4)
                        {
                            orangeTribbleColor = Color.Blue;
                        }
                    }

                    // Up n Down
                    orangeTribbleRect.Y += (int)orangeTribbleSpeed.Y;
                    if (orangeTribbleRect.Top < 0 || orangeTribbleRect.Bottom > window.Height)
                    {
                        bounces++;
                        orangeTribbleSpeed.Y *= -1;

                        numColors = random.Next(0, 5);

                        if (numColors == 0)
                        {
                            orangeTribbleColor = Color.White;
                        }
                        else if (numColors == 1)
                        {
                            orangeTribbleColor = Color.Red;
                        }
                        else if (numColors == 2)
                        {
                            orangeTribbleColor = Color.Yellow;
                        }
                        else if (numColors == 3)
                        {
                            orangeTribbleColor = Color.Green;
                        }
                        else if (numColors == 4)
                        {
                            orangeTribbleColor = Color.Blue;
                        }
                    }
                } // Orange Tribble

                if (bounces >= 150)
                {
                    Exit();
                }
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            if (screen == Screen.Intro)
            {
                _spriteBatch.Draw(backgroundIntroTexture, window, Color.White);
            }
            else if (screen == Screen.MainAnimation)
            {
                _spriteBatch.Draw(backgroundTexture, new Vector2(0, 0), Color.White);
                _spriteBatch.Draw(brownTribbleTexture, brownTribbleRect, brownTribbleColor);
                _spriteBatch.Draw(creamTribbleTexture, creamTribbleRect, creamTribbleColor);
                _spriteBatch.Draw(greyTribbleTexture, greyTribbleRect, greyTribbleColor);
                _spriteBatch.Draw(orangeTribbleTexture, orangeTribbleRect, orangeTribbleColor);
            }

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
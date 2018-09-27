using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsalia.Scenes
{
    class StartScene : Scene
    {
        public StartScene() : base()
        {
            AddGraphic(Image.CreateRectangle(Game.Instance.Width, Game.Instance.Height, Color.Blue));
        }


        public override void Update()
        {
            base.Update();

            if (Input.KeyPressed(Key.Space))
            {
                // When the space bar is pressed switch to the SecondScene.
                Game.SwitchScene(new MainScene());
            }
        }
    }
}

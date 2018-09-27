using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsalia.Scenes
{
    class MainScene : Scene
    {
        public MainScene() : base()
        {
            Add(new Character(Game.Instance.HalfWidth, Game.Instance.HalfHeight));
        }


        public override void Update()
        {
            base.Update();

        }
    }
}

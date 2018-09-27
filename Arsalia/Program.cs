using Arsalia.Scenes;
using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsalia
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game("Arsalia",640,480,60,false);

            // Set the background color to a bluish hue.
            game.Color = new Color(0.3f, 0.5f, 0.7f);

            // Create a scene.
            var scene = new Scene();
            // Add the animating entity to the scene.
            scene.Add(new Character(game.HalfWidth, game.HalfHeight));

            // Start the game with the scene that was just created.
            game.Start(new StartScene());
        }
    }
}

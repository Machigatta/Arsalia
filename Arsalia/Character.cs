using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arsalia
{
    class Character : Entity
    {
        bool keyPressed = false;
        public float MoveSpeed = 5;

        enum Animation
        {
            WalkUp,
            WalkDown,
            WalkLeft,
            WalkRight,
            PlayOnce,
            Standing
        }

        Spritemap<Animation> spritemap = new Spritemap<Animation>("c:/users/armin/documents/visual studio 2015/Projects/Arsalia/Arsalia/Sprites/Character/Cadia.png", 32, 32);

        public Character(float x, float y) : base(x, y) {
            spritemap.Add(Animation.WalkUp, "0,1,2,3,4,5", 4);
            spritemap.Add(Animation.WalkRight, "6,7,8,9,10,11", 4);
            spritemap.Add(Animation.WalkDown, "12,13,14,15,16,17", 4);
            spritemap.Add(Animation.WalkLeft, "18,19,20,21,22,23", 4);
            spritemap.Add(Animation.PlayOnce, "5,11,17,23,5,11,17,23", 6).NoRepeat();
            spritemap.Add(Animation.Standing, "12,15", 8).PingPong();

            spritemap.CenterOrigin();
            spritemap.Play(Animation.Standing);
            AddGraphic(spritemap);
        }

        public override void Update()
        {
            base.Update();

            if (Input.KeyDown(Key.W) && !keyPressed)
            {
                keyPressed = true;
                spritemap.Play(Animation.WalkUp,false);
                Y -= MoveSpeed;
            }
            if (Input.KeyDown(Key.S) && !keyPressed)
            {
                keyPressed = true;
                spritemap.Play(Animation.WalkDown, false);
                Y += MoveSpeed;
            }
            if (Input.KeyDown(Key.A) && !keyPressed)
            {
                keyPressed = true;
                spritemap.Play(Animation.WalkLeft, false);
                X -= MoveSpeed;
            }
            if (Input.KeyDown(Key.D) && !keyPressed)
            {
                keyPressed = true;
                spritemap.Play(Animation.WalkRight, false);
                X += MoveSpeed;
            }
            if (Input.KeyDown(Key.X))
            {
                keyPressed = true;
                spritemap.Play(Animation.PlayOnce);
            }


            if (!keyPressed)
            {
                spritemap.Play(Animation.Standing,false);
            }

            keyPressed = false;
        }
    }
}

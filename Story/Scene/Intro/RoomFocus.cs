using System;
using System.Collections;
using System.Collections.Generic;
using TextBaseGame.Interfaces;
using TextBaseGame.Players;

namespace TextBaseGame.Story.Scene.Intro
{
    internal class RoomFocus : IFocusState<IntroScene>
    {
        private string actionText = "Te afli într-o cameră întunecată. Poți vedea o cutie pe masă, un tablou pe perete, o fotografie pe noptiera, un covor urat pe podea.";
        public string Name => "Camera (privire in ansamblu)";
        public string Description => actionText;

        public IEnumerable<string> AvailableCommands
        {
            get
            {
                yield return "look box";
                yield return "look painting";
                yield return "look carpet";
                yield return "look photo";
            }
        }

        public void HandleCommand(string input, Player player, IntroScene scene)
        {
            switch (input)
            {
                case "look box":
                    scene.ChangeFocus(new BoxFocus());
                    break;
                case "look painting":
                    scene.ChangeFocus(new PaintingFocus());
                    break;
                case "look carpet":
                    scene.ChangeFocus(new CarpetFocus());
                    break;
                case "look photo":
                    scene.ChangeFocus(new PhotoFocus());
                    break;
                default:
                    actionText = "Comanda necunoscută.";
                    break;
            }

        }
    }
}

using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework.Graphics;

namespace Gwynwhyvaar.SkiesOfAzurya.WinDx.Objects
{
    [Serializable]
    public class TitleScreen
    {
        public Dictionary<string, Model> TitleModels = new Dictionary<string, Model>();
        public Model TitleModel { get; set; }
        public Model BackgroundModel { get; set; }
        public Texture2D BackgroundTitleTexture { get; set; }
    }
}

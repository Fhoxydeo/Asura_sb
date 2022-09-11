using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using StorybrewCommon.Subtitles;
using StorybrewCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorybrewScripts
{
    public class IrpanLyrics : StoryboardObjectGenerator
    {
        FontGenerator fg;
        public override void Generate()
        {
            fg = LoadFont("sb/lyrics",
            new FontDescription{
                FontPath = "sb/BIZ-UDMinchoM.ttc",
                FontSize = 128,
                Color = Color4.White,
                Padding = Vector2.Zero,
                FontStyle = System.Drawing.FontStyle.Regular,
                TrimTransparency = true,
                EffectsOnly = false,
                Debug = false
            });
            
            SpawnLyric("あ", 56463, 57631);
            SpawnLyric("壊れちゃった", 57965, 59631);
            SpawnLyric("真実さえ", 59965, 61465);
            SpawnLyric("分け合えないなら", 61798, 64630);
            SpawnLyric("これでいい",65630, 66797);            
            SpawnLyric("わけないな", 67130, 67964);
            SpawnLyric("焼き付いて離れない", 68297, 70630);
            SpawnLyric("僕を突き", 70964, 71964);
            SpawnLyric("動かして", 72630, 75297);
            SpawnLyric("溢れて", 76297, 77630);
            SpawnLyric("あ", 77880, 78630);
            SpawnLyric("その静かな怒りを", 78964, 83963);
            SpawnLyric("飼い慣らせ", 84296, 88296);


        }

        void SpawnLyric(string text, int startTime, int endTime)
        {
            var texture = fg.GetTexture(text);
            var sprite = GetLayer("Lyrics").CreateSprite(texture.Path, OsbOrigin.Centre);

            sprite.Fade(startTime - 200, startTime, 0, 1);
            sprite.Fade(endTime , endTime + 200, 1, 0);
            sprite.Scale(startTime, endTime, 0.13, 0.13);
            sprite.MoveY(startTime, endTime, 400, 400);
        }
    }
}

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
                
            },
            new FontShadow()
            {
                Thickness = 6,
                Color = Color4.Black,
            });
            
            SpawnLyric("あ", 6131, 6964);
            SpawnLyric("忘れちゃった", 7131, 8797);
            SpawnLyric("靴紐の", 9130, 10297);
            SpawnLyric("結び方今朝は", 10630, 13462);
            SpawnLyric("走れない",14129, 15298);
            SpawnLyric("もういいや",15465, 16631);
            SpawnLyric("こうして",16798, 17965);
            SpawnLyric("突然に", 18131, 19298);
            SpawnLyric("盗まれ", 19465, 20798);
            SpawnLyric("ていくだろう", 21048, 23798);
            SpawnLyric("横断", 24798, 25965);
            SpawnLyric("歩道の", 26131, 27298);
            SpawnLyric("黒を昨日", 27465, 29881);
            SpawnLyric("踏んでしまったし", 30131, 33464);
            SpawnLyric("あ", 35964, 36631);
            SpawnLyric("ピンセットで", 36798, 38798);
            SpawnLyric("摘み上げら", 39131, 40464);
            SpawnLyric("れては狼狽", 40798, 41640);
            SpawnLyric("良い人だ", 41798, 42631);
            SpawnLyric("絶対白", 42798, 43631);
            SpawnLyric("嘘ばかり", 43798, 45130);
            SpawnLyric("手垢の", 45630, 47797);
            SpawnLyric("ついた", 48130, 50297);
            SpawnLyric("ロマンに",50630, 51297);
            SpawnLyric("使い切られ嫌気が刺す", 51463, 52963);
            SpawnLyric("虚空のプラスチック", 53463, 54463);
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

            sprite.Fade(startTime - 100, startTime, 0, 1);
            sprite.Fade(endTime , endTime + 150, 1, 0);
            sprite.Scale(startTime, endTime, 0.13, 0.13);
            sprite.MoveY(startTime, endTime, 400, 400);
        }
    }
}

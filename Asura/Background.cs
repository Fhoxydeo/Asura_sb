using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using System.Linq;

namespace StorybrewScripts
{
    public class Background : StoryboardObjectGenerator
    {
        [Configurable]
        public string BackgroundPath = "";

        [Configurable]
        public int StartTime = 0;

        [Configurable]
        public int EndTime = 0;

        [Configurable]
        public double Opacity = 0.2;

        public override void Generate()
        {
            if (BackgroundPath == "") BackgroundPath = Beatmap.BackgroundPath ?? string.Empty;
            if (StartTime == EndTime) EndTime = (int)(Beatmap.HitObjects.LastOrDefault()?.EndTime ?? AudioDuration);

            var bitmap = GetMapsetBitmap(BackgroundPath);
            var bg = GetLayer("").CreateSprite(BackgroundPath, OsbOrigin.Centre);
            bg.Scale(StartTime, 480.0f / bitmap.Height);
            bg.Fade(StartTime - 500, StartTime, 0, Opacity);
            bg.StartLoopGroup(0, 23);
            bg.Rotate(0, 2000,-0.016, 0.016);
            bg.Rotate(2000, 4000, 0.016, -0.016);
            bg.EndGroup();
        }
    }
}

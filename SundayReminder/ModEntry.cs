using System;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace SundayReminder
{
    public class ModEntry : Mod
    {
        public override void Entry(IModHelper helper)
        {
            TimeEvents.AfterDayStarted += this.TimeEvents_AfterDayStarted;
        }

        private void TimeEvents_AfterDayStarted(object sender, EventArgs e)
        {
            if (!Context.IsWorldReady)
                return;

            var date = SDate.Now();
            if(date.DayOfWeek.ToString().Equals("Sunday"))
                Game1.addHUDMessage(new HUDMessage("It's Sunday morning. Maybe you should relax and watch a cooking show.", 2));
        }
    }
}

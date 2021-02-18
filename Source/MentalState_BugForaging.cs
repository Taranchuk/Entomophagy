using RimWorld;
using Verse;
using Verse.AI;

namespace Entomophagy
{
    class MentalState_BugForaging : MentalState
    {
        public override RandomSocialMode SocialModeMax()
        {
            return RandomSocialMode.Quiet;
        }

        public override void MentalStateTick()
        {
            if (this.pawn.IsHashIntervalTick(150))
            {
                pawn.needs.food.CurLevel += .01f;
                base.MentalStateTick();
                if ((pawn.Map != null && !JoyUtility.EnjoyableOutsideNow(pawn.Map)) || HealthAIUtility.ShouldBeTendedNowByPlayer(pawn))
                {
                    //Log.Message("Not a good time for foraging");
                    RecoverFromState();
                    return;
                }
            }
        }

        public override void PostEnd()
        {
            pawn.needs.mood.thoughts.memories.TryGainMemory(def.moodRecoveryThought, null);
        }
    }
}

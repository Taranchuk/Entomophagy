using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;
using UnityEngine;

namespace Entomophagy
{
    public class ModSettings_Entomophagy : ModSettings
    {
        public static bool insectRecipes = false;
        public static bool replaceMeals = true;

        public override void ExposeData()
        {
            Scribe_Values.Look(ref insectRecipes, "insectRecipes", false);
            Scribe_Values.Look(ref replaceMeals, "replaceMeals", true);
            base.ExposeData();
        }

    }
}

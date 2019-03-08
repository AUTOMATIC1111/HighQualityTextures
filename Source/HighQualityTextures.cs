using Harmony;
using RimWorld;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine;
using Verse;

namespace HighQualityTextures
{
    public class HighQualityTextures :Mod
    {
        public HighQualityTextures(ModContentPack pack) :base(pack) {
            var harmony = HarmonyInstance.Create("com.github.automatic1111.highqualitytextures");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }   
    }
}

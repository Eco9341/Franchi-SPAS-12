using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.Models.Common;
using SPTarkov.Server.Core.Models.Eft.Common.Tables;
using SPTarkov.Server.Core.Models.Utils;
using SPTarkov.Server.Core.Services;
using WTTServerCommonLib.Helpers;

namespace FranchiSPAS12.Helpers
{
    [Injectable]
    public class EcoQuestHelper(DatabaseService  databaseService, ISptLogger<EcoQuestHelper> logger, QuestHelper questHelper)
    {

        // Define weapon IDs
        // ReSharper disable InconsistentNaming
        // ReSharper disable IdentifierTypo
        //snipers
        //shotguns
        private const string FRANCHI_SPAS_12 = "6a22b76bbe1815d0c5c0f903";
        //smg
        //pistols
        
        //rifles 
        //dmr
        
        // Weapon Mods
        
        public void ModifyQuests()
        {
            var quests = databaseService.GetTemplates().Quests;

            // ReSharper disable CommentTypo
            // ====================== PRAPOR QUESTS ======================

            // Punisher Part 4 (59ca264786f77445a80ed044)
            questHelper.AddWeaponsToKillCondition(quests, "59ca264786f77445a80ed044", [
                FRANCHI_SPAS_12
            ]);
            
            // Silent Caliber (5c0bc91486f7746ab41857a2)
            questHelper.AddWeaponsToKillCondition(quests, "5c0bc91486f7746ab41857a2", [
                FRANCHI_SPAS_12
            ]);

            // Setup (5c1234c286f77406fa13baeb)
            questHelper.AddWeaponsToKillCondition(quests, "5c1234c286f77406fa13baeb", [
                FRANCHI_SPAS_12
            ]);
            
            // Spa Tour Part 1 (5a03153686f77442d90e2171)
            questHelper.AddWeaponsToKillCondition(quests, "5a03153686f77442d90e2171", [
                FRANCHI_SPAS_12
            ]);
            
            // Claustrophobia (669fa3979b0ce3feae01a130)
            questHelper.AddWeaponsToKillCondition(quests, "669fa3979b0ce3feae01a130", [
                FRANCHI_SPAS_12
            ]);
            
        }
    }
}

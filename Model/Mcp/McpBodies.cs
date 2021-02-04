using Fortnite.Net.Model.Fortnite;

namespace Fortnite.Net.Model.Mcp
{
    public static class McpBodies
    {

        public static object CreateAbandonExpeditionPayload(string expeditionId) => new
        {
            ExpeditionId = expeditionId
        };

        public static object CreateActivateConsumablePayload(string targetItemId) => new
        {
            TargetItemId = targetItemId
        };

        public static object CreateApplyAlterationPayload(string alterationItemId, string targetItemId) => new
        {
            AlterationItemId = alterationItemId,
            TargetItemId = targetItemId
        };

        public static object CreateApplyVotePayload(string offerId) => new
        {
            OfferId = offerId
        };

        public static object CreateAssignGadgetToLoadoutPayload(string gadgetId, string loadoutId) => new
        {
            GadgetId = gadgetId,
            LoadoutId = loadoutId
        };
        
        public static object CreateAssignHeroToLoadoutPayload(string slotName, string loadoutId, string heroId) => new
        {
            SlotName = slotName,
            LoadoutId = loadoutId,
            HeroId = heroId
        };

        public static object CreateAssignTeamPerkToLoadoutPayload(string teamPerkId, string loadoutId) => new
        {
            TeamPerkId = teamPerkId,
            LoadoutId = loadoutId
        };

        public static object CreateAssignWorkerToSquadPayload(string squadId, string characterId) => new
        {
            SquadId = squadId,
            CharacterId = characterId
        };

        public static object CreateClaimCollectedResourcesPayload(params string[] collectorsToClaim) => new
        {
            CollectorsToClaim = collectorsToClaim
        };

        public static object CreateClaimCollectionBookRewardsPayload() => new object();

        public static object CreateClaimDifficultyIncreaseRewardsPayload() => new object();

        public static object CreateClaimImportFriendsRewardPayload() => new object();

        public static object CreateClaimLoginRewardPayload() => new object();

        public static object CreateClaimMfaEnabledPayload(bool bClaimForStw = false) => new
        {
            bClaimForStw
        };

        public static object CreateClaimMissionAlertRewardsPayload() => new object();
        
        public static object CreateClaimQuestRewardPayload(string questId) => new
        {
            QuestId = questId
        };

        public static object CreateClientQuestLoginPayload() => new object();

        public static object CreateCollectExpeditionPayload(string expeditionId, string expeditionTemplate) => new
        {
            ExpeditionId = expeditionId,
            ExpeditionTemplate = expeditionTemplate
        };

        public static object CreateCompletePlayerSurveyPayload(string surveyId) => new
        {
            SurveyId = surveyId
        };
        
        public static object CreateConvertItemPayload(string targetItemId) => new
        {
            TargetItemId = targetItemId
        };

        public static object CreateConvertLegacyAlternationsPayload(string targetItemId) => new
        {
            TargetItemId = targetItemId
        };
        
        public static object CreateCraftWorldItemPayload(string targetSchematicItemId, int numTimesToCraft, string targetSchematicTier) => new
        {
            TargetSchematicItemId = targetSchematicTier,
            NumTimesToCraft = numTimesToCraft,
            TargetSchematicTier = targetSchematicTier
        };

        public static object CreateDestroyWorldItemsPayload(params string[] itemIds) => new
        {
            ItemIds = itemIds
        };

        public static object CreateEquipCampaignCustomizationPayload(string slotName, string itemToSlot) => new
        {
            SlotName = slotName,
            ItemToSlot = itemToSlot
        };

        public static object CreateGenerateDailyQuestsPayload() => new object();

        public static object CreateGetMcpTimeForLoginPayload() => new object();

        public static object CreateGiftCatalogEntryPayload(
            string offerId,
            int purchaseQuantity,
            string currency,
            int expectedTotalPrice,
            string gameContext,
            string[] receiverAccountIds,
            string giftWrapTemplateId,
            string personalMessage
        ) => new
        {
            OfferId = offerId,
            PurchaseQuantity = purchaseQuantity,
            Currency = currency,
            ExpectedTotalPrice = expectedTotalPrice,
            GameContext = gameContext,
            ReceivedAccountIds = receiverAccountIds,
            GiftWrapTemplateId = giftWrapTemplateId,
            PersonalMessage = personalMessage
        };
        
        public static object CreateIncrementNamedCounterStatPayload(string counterName) => new
        {
            CounterName = counterName
        };

        public static object CreateIssueFriendCodePayload(string codeTokenType) => new
        {
            CodeTokenType = codeTokenType
        };

        public static object CreateMarkItemSeenPayload(params string[] itemIds) => new
        {
            ItemId = itemIds
        };
        
        public static object CreateMarkNewQuestNotificationSentPayload(params string[] itemIds) => new
        {
            ItemId = itemIds
        };

        public static object CreateOpenCardPackPayload(string cardPackItemId) => new
        {
            CardPackItemId = cardPackItemId
        };

        public static object CreatePopulatePrerolledOffersPayload() => new object();

        public static object CreatePurchaseCatalogEntryPayload(
            string offerId,
            int purchaseQuantity,
            string currency,
            int expectedTotalPrice,
            string gameContext
        ) => new
        {
            OfferId = offerId,
            PurchaseQuantity = purchaseQuantity,
            Currency = currency,
            ExpectedTotalPrice = expectedTotalPrice,
            GameContext = gameContext
        };

        public static object CreatePurchaseOrUpgradeHomebaseNodePayload(string nodeId) => new
        {
            NodeId = nodeId
        };

        public static object CreatePurchaseResearchStatUpgradePayload(string statId) => new
        {
            StatId = statId
        };

        public static object CreateQueryProfilePayload() => new object();

        public static object CreateRecycleItemPayload(string targetItemId) => new
        {
            TargetItemId = targetItemId
        };

        public static object CreateRecycleItemBatchPayload(params string[] targetItemIds) => new
        {
            TargetItemIds = targetItemIds
        };

        public static object CreateRefreshExpeditionsPayload() => new object();

        public static object CreateRefundItemPayload(string targetItemId) => new
        {
            TargetItemId = targetItemId
        };
        
        public static object CreateRefundMtxPurchasePayload(string purchaseId, bool quickReturn) => new
        {
            PurchaseId = purchaseId,
            QuickReturn = quickReturn
        };

        public static object CreateRemoveGiftBoxPayload(params string[] giftBoxItemIds) => new
        {
            GiftBoxItemIds = giftBoxItemIds
        };
        
        public static object CreateResearchItemFromCollectionBookPayload(string templateId) => new
        {
            TemplateId = templateId
        };

        public static object CreateRespecAlterationPayload(
            string targetItemId,
            string alterationSlot,
            string alterationId
        ) => new
        {
            TargetItemId = targetItemId,
            AlterationSlot = alterationSlot,
            AlterationId = alterationId
        };

        public static object CreateSelectStartOptionsPayload(
            string characterTemplateId,
            string displayName,
            string affiliateId
        ) => new
        {
            CharacterTemplateId = characterTemplateId,
            DisplayName = displayName,
            AffiliateId = affiliateId
        };

        public static object CreateSetAffiliateNamePayload(string affiliateName) => new
        {
            AffiliateName = affiliateName
        };

        public static object CreateSetAvatarAndFlagsPayload(string newAvatar, string newFlag) => new
        {
            NewAvatar = newAvatar,
            NewFlag = newFlag
        };

        public static object CreateSetCosmeticLockerSlotPayload(
            string lockerItem,
            string category,
            string itemToSlot,
            int slotIndex,
            params VariantUpdate[] variantUpdates
        ) => new
        {
            LockerItem = lockerItem,
            Category = category,
            ItemToSlot = itemToSlot,
            SlotIndex = slotIndex,
            VariantUpdated = variantUpdates
        };
        
        /*public static object CreateSetHomebaseBannerPayload(
            
        )*/

    }
}
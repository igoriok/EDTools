using ED.Tools.Inara.Models;
using System;
using System.Collections.Generic;

namespace ED.Tools.Inara
{
    public static class RequestExtensions
    {
        public static Request AddEvent<TRequestEventData>(this Request request, string eventName, TRequestEventData eventData, DateTime? date = null, int? customID = null)
        {
            request.Events.Add(new RequestEvent<TRequestEventData>(eventName, eventData, date, customID));
            return request;
        }

        public static Request AddEvent<TRequestEventData, TResponseEventData>(this Request request, string eventName, TRequestEventData eventData, DateTime? date = null, int? customID = null)
        {
            request.Events.Add(new RequestEvent<TRequestEventData, TResponseEventData>(eventName, eventData, date, customID));
            return request;
        }

        public static Request AddCommanderFriend(this Request request, CommanderFriend eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("addCommanderFriend", eventData, date, customID);
        }

        public static Request AddCommanderFriend(this Request request, string commanderName, string gamePlatform, DateTime? date = null, int? customID = null)
        {
            return request.AddCommanderFriend(new CommanderFriend(commanderName, gamePlatform), date, customID);
        }

        public static Request DelCommanderFriend(this Request request, CommanderFriend eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("delCommanderFriend", eventData, date, customID);
        }

        public static Request DelCommanderFriend(this Request request, string commanderName, string gamePlatform, DateTime? date = null, int? customID = null)
        {
            return request.DelCommanderFriend(new CommanderFriend(commanderName, gamePlatform), date, customID);
        }

        public static Request GetCommanderProfile(this Request request, CommanderProfileRequest eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent<CommanderProfileRequest, CommanderProfile>("getCommanderProfile", eventData, date, customID);
        }

        public static Request GetCommanderProfile(this Request request, string searchName, DateTime? date = null, int? customID = null)
        {
            return request.GetCommanderProfile(new CommanderProfileRequest(searchName), date, customID);
        }

        public static Request AddCommanderPermit(this Request request, CommanderPermit eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("addCommanderPermit", eventData, date, customID);
        }

        public static Request AddCommanderPermit(this Request request, string starSystemName, DateTime? date = null, int? customID = null)
        {
            return request.AddCommanderPermit(new CommanderPermit(starSystemName), date, customID);
        }

        public static Request SetCommanderCredits(this Request request, CommanderCredits eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("setCommanderCredits", eventData, date, customID);
        }

        public static Request SetCommanderCredits(this Request request, int commanderCredits, int? commanderAssets = null, int? commanderLoan = null, DateTime? date = null, int? customID = null)
        {
            return request.SetCommanderCredits(new CommanderCredits(commanderCredits, commanderAssets, commanderLoan), date, customID);
        }

        public static Request SetCommanderGameStatistics(this Request request, CommanderGameStatistics eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("setCommanderGameStatistics", eventData, date, customID);
        }

        public static Request SetCommanderRankEngineer(this Request request, CommanderRankEngineer eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("setCommanderRankEngineer", eventData, date, customID);
        }

        public static Request SetCommanderRankEngineer(this Request request, string engineerName, string rankStage = null, int? rankValue = null, DateTime? date = null, int? customID = null)
        {
            return request.SetCommanderRankEngineer(new CommanderRankEngineer(engineerName, rankStage, rankValue), date, customID);
        }

        public static Request SetCommanderRankEngineer(this Request request, CommanderRankEngineer[] eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("setCommanderRankEngineer", eventData, date, customID);
        }

        public static Request SetCommanderRankPilot(this Request request, CommanderRankPilot eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("setCommanderRankPilot", eventData, date, customID);
        }

        public static Request SetCommanderRankPilot(this Request request, string rankName, int? rankValue = null, float? rankProgress = null, DateTime? date = null, int? customID = null)
        {
            return request.SetCommanderRankPilot(new CommanderRankPilot(rankName, rankValue, rankProgress), date, customID);
        }

        public static Request SetCommanderRankPower(this Request request, CommanderRankPower eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("setCommanderRankPower", eventData, date, customID);
        }

        public static Request SetCommanderRankPower(this Request request, string powerName, int rankValue, DateTime? date = null, int? customID = null)
        {
            return request.SetCommanderRankPower(new CommanderRankPower(powerName, rankValue), date, customID);
        }

        public static Request SetCommanderReputationMajorFaction(this Request request, CommanderReputationMajorFaction eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("setCommanderReputationMajorFaction", eventData, date, customID);
        }

        public static Request SetCommanderReputationMajorFaction(this Request request, string majorFactionName, float majorFactionReputation, DateTime? date = null, int? customID = null)
        {
            return request.SetCommanderReputationMajorFaction(new CommanderReputationMajorFaction(majorFactionName, majorFactionReputation), date, customID);
        }

        public static Request SetCommanderReputationMajorFaction(this Request request, CommanderReputationMajorFaction[] eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("setCommanderReputationMajorFaction", eventData, date, customID);
        }

        public static Request SetCommanderReputationMinorFaction(this Request request, CommanderReputationMinorFaction eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("setCommanderReputationMinorFaction", eventData, date, customID);
        }

        public static Request SetCommanderReputationMinorFaction(this Request request, string minorFactionName, float minorFactionReputation, DateTime? date = null, int? customID = null)
        {
            return request.SetCommanderReputationMinorFaction(new CommanderReputationMinorFaction(minorFactionName, minorFactionReputation), date, customID);
        }

        public static Request SetCommanderReputationMinorFaction(this Request request, CommanderReputationMinorFaction[] eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("setCommanderReputationMinorFaction", eventData, date, customID);
        }

        public static Request AddCommanderInventoryCargoItem(this Request request, CommanderInventoryCargo eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("addCommanderInventoryCargoItem", eventData, date, customID);
        }

        public static Request AddCommanderInventoryCargoItem(this Request request,
            string itemName, int itemCount, bool? isStolen = null, int? missionGameID = null,
            DateTime? date = null, int? customID = null)
        {
            return request.AddCommanderInventoryCargoItem(new CommanderInventoryCargo(itemName, itemCount, isStolen, missionGameID), date, customID);
        }

        public static Request DelCommanderInventoryCargoItem(this Request request, CommanderInventoryCargo eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("delCommanderInventoryCargoItem", eventData, date, customID);
        }

        public static Request DelCommanderInventoryCargoItem(this Request request,
            string itemName, int itemCount, bool? isStolen = null, int? missionGameID = null,
            DateTime? date = null, int? customID = null)
        {
            return request.DelCommanderInventoryCargoItem(new CommanderInventoryCargo(itemName, itemCount, isStolen, missionGameID), date, customID);
        }

        public static Request SetCommanderInventoryCargo(this Request request, CommanderInventoryCargo[] eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("setCommanderInventoryCargo", eventData, date, customID);
        }

        public static Request SetCommanderInventoryCargoItem(this Request request, CommanderInventoryCargo eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("setCommanderInventoryCargoItem", eventData, date, customID);
        }

        public static Request SetCommanderInventoryCargoItem(this Request request,
            string itemName, int itemCount, bool? isStolen = null, int? missionGameID = null,
            DateTime? date = null, int? customID = null)
        {
            return request.SetCommanderInventoryCargoItem(new CommanderInventoryCargo(itemName, itemCount, isStolen, missionGameID), date, customID);
        }

        public static Request AddCommanderInventoryMaterialsItem(this Request request, CommanderInventoryMaterialsItem eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("addCommanderInventoryMaterialsItem", eventData, date, customID);
        }

        public static Request AddCommanderInventoryMaterialsItem(this Request request, string itemName, int itemCount, DateTime? date = null, int? customID = null)
        {
            return request.AddCommanderInventoryMaterialsItem(new CommanderInventoryMaterialsItem(itemName, itemCount), date, customID);
        }

        public static Request DelCommanderInventoryMaterialsItem(this Request request, CommanderInventoryMaterialsItem eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("delCommanderInventoryMaterialsItem", eventData, date, customID);
        }

        public static Request DelCommanderInventoryMaterialsItem(this Request request, string itemName, int itemCount, DateTime? date = null, int? customID = null)
        {
            return request.DelCommanderInventoryMaterialsItem(new CommanderInventoryMaterialsItem(itemName, itemCount), date, customID);
        }

        public static Request SetCommanderInventoryMaterials(this Request request, CommanderInventoryMaterialsItem[] eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("setCommanderInventoryMaterials", eventData, date, customID);
        }

        public static Request SetCommanderInventoryMaterialsItem(this Request request, CommanderInventoryMaterialsItem eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("setCommanderInventoryMaterialsItem", eventData, date, customID);
        }

        public static Request SetCommanderInventoryMaterialsItem(this Request request, string itemName, int itemCount, DateTime? date = null, int? customID = null)
        {
            return request.SetCommanderInventoryMaterialsItem(new CommanderInventoryMaterialsItem(itemName, itemCount), date, customID);
        }

        public static Request SetCommanderStorageModules(this Request request, CommanderStorageModule[] eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("setCommanderStorageModules", eventData, date, customID);
        }

        public static Request AddCommanderShip(this Request request, CommanderShip eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("addCommanderShip", eventData, date, customID);
        }

        public static Request AddCommanderShip(this Request request, string shipType, int shipGameID, DateTime? date = null, int? customID = null)
        {
            return request.AddCommanderShip(new CommanderShip(shipType, shipGameID), date, customID);
        }

        public static Request DelCommanderShip(this Request request, CommanderShip eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("delCommanderShip", eventData, date, customID);
        }

        public static Request DelCommanderShip(this Request request, string shipType, int shipGameID, DateTime? date = null, int? customID = null)
        {
            return request.DelCommanderShip(new CommanderShip(shipType, shipGameID), date, customID);
        }

        public static Request SetCommanderShip(this Request request, CommanderShipDetails eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("setCommanderShip", eventData, date, customID);
        }

        public static Request SetCommanderShip(this Request request,
            string shipType, int shipGameID, string shipName = null, string shipIdent = null,
            bool? isCurrentShip = null, bool? isMainShip = null, bool? isHot = null,
            int? shipHullValue = null, int? shipModulesValue = null, int? shipReBuyCost = null,
            string starSystemName = null, string stationName = null, int? marketID = null,
            DateTime? date = null, int? customID = null)
        {
            return request.SetCommanderShip(new CommanderShipDetails(
                    shipType, shipGameID, shipName, shipIdent, isCurrentShip, isMainShip, isHot,
                    shipHullValue, shipModulesValue, shipReBuyCost, starSystemName, stationName, marketID),
                date, customID);
        }

        public static Request SetCommanderShipLoadout(this Request request, CommanderShipLoadout eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("setCommanderShipLoadout", eventData, date, customID);
        }

        public static Request SetCommanderShipLoadout(this Request request, string shipType, int shipGameID, ShipLoadout[] shipLoadout, DateTime? date = null, int? customID = null)
        {
            return request.SetCommanderShipLoadout(new CommanderShipLoadout(shipType, shipGameID, shipLoadout), date, customID);
        }

        public static Request SetCommanderShipTransfer(this Request request, CommanderShipTransfer eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("setCommanderShipTransfer", eventData, date, customID);
        }

        public static Request SetCommanderShipTransfer(this Request request,
            string shipType, int shipGameID, string starSystemName, string stationName, int? marketID = null, int? transferTime = null,
            DateTime? date = null, int? customID = null)
        {
            return request.SetCommanderShipTransfer(new CommanderShipTransfer(shipType, shipGameID, starSystemName, stationName, marketID, transferTime), date, customID);
        }

        public static Request AddCommanderTravelDock(this Request request, CommanderTravelDock eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("addCommanderTravelDock", eventData, date, customID);
        }

        public static Request AddCommanderTravelDock(this Request request,
            string starSystemName, string stationName, int? marketID = null, string shipType = null, int? shipGameID = null,
            DateTime? date = null, int? customID = null)
        {
            return request.AddCommanderTravelDock(new CommanderTravelDock(starSystemName, stationName, marketID, shipType, shipGameID), date, customID);
        }

        public static Request AddCommanderTravelFSDJump(this Request request, CommanderTravelFSDJump eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("addCommanderTravelFSDJump", eventData, date, customID);
        }

        public static Request AddCommanderTravelFSDJump(this Request request,
            string starSystemName, float? jumpDistance = null, string shipType = null, int? shipGameID = null,
            DateTime? date = null, int? customID = null)
        {
            return request.AddCommanderTravelFSDJump(new CommanderTravelFSDJump(starSystemName, jumpDistance, shipType, shipGameID), date, customID);
        }

        public static Request SetCommanderTravelLocation(this Request request,
            string starSystemName, string stationName = null, int? marketID = null,
            DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("setCommanderTravelLocation", new CommanderTravelLocation(starSystemName, stationName, marketID), date, customID);
        }

        public static Request AddCommanderMission(this Request request, CommanderMission eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("addCommanderMission", eventData, date, customID);
        }

        public static Request AddCommanderMission(this Request request,
            string missionName, string missionGameID, string starSystemNameOrigin, DateTime? missionExpiry = null,
            string influenceGain = null, string reputationGain = null, string stationNameOrigin = null, string minorFactionNameOrigin = null,
            string starSystemNameTarget = null, string stationNameTarget = null, string minorFactionNameTarget = null,
            string commodityName = null, int? commodityCount = null, string targetName = null, string targetType = null, int? killCount = null,
            string passengerType = null, int? passengerCount = null, bool? passengerIsVIP = null, bool? passengerIsWanted = null, DateTime? date = null, int? customID = null)
        {
            return request.AddCommanderMission(new CommanderMission(
                    missionName, missionGameID, starSystemNameOrigin, missionExpiry, influenceGain, reputationGain,
                    stationNameOrigin, minorFactionNameOrigin, starSystemNameTarget, stationNameTarget, minorFactionNameTarget,
                    commodityName, commodityCount, targetName, targetType, killCount, passengerType, passengerCount, passengerIsVIP, passengerIsWanted),
                date, customID);
        }

        public static Request SetCommanderMissionAbandoned(this Request request, CommanderMissionAbandoned eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("setCommanderMissionAbandoned", eventData, date, customID);
        }

        public static Request SetCommanderMissionAbandoned(this Request request, string missionGameID, DateTime? date = null, int? customID = null)
        {
            return request.SetCommanderMissionAbandoned(new CommanderMissionAbandoned(missionGameID), date, customID);
        }

        public static Request SetCommanderMissionCompleted(this Request request, CommanderMissionCompleted eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("setCommanderMissionCompleted", eventData, date, customID);
        }

        public static Request SetCommanderMissionCompleted(this Request request,
            string missionGameID, int? donationCredits = null, int? rewardCredits = null,
            RewardPermit[] rewardPermits = null, RewardCommodity[] rewardCommodities = null,
            RewardMaterial[] rewardMaterials = null, MinorFactionEffect[] minorFactionEffects = null,
            DateTime? date = null, int? customID = null)
        {
            return request.SetCommanderMissionCompleted(new CommanderMissionCompleted(
                    missionGameID, donationCredits, rewardCredits, rewardPermits, rewardCommodities, rewardMaterials, minorFactionEffects),
                date, customID);
        }

        public static Request AddCommanderCombatDeath(this Request request, CommanderCombatDeath eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("addCommanderCombatDeath", eventData, date, customID);
        }

        public static Request AddCommanderCombatDeath(this Request request,
            string starSystemName, string opponentName = null, string[] wingOpponentNames = null, bool? isPlayer = null,
            DateTime? date = null, int? customID = null)
        {
            return request.AddCommanderCombatDeath(new CommanderCombatDeath(starSystemName, opponentName, wingOpponentNames, isPlayer), date, customID);
        }

        public static Request AddCommanderCombatInterdicted(this Request request, CommanderCombatInterdicted eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("addCommanderCombatInterdicted", eventData, date, customID);
        }

        public static Request AddCommanderCombatInterdicted(this Request request, string starSystemName, string opponentName, bool isPlayer, bool? isSubmit = null, DateTime? date = null, int? customID = null)
        {
            return request.AddCommanderCombatInterdicted(new CommanderCombatInterdicted(starSystemName, opponentName, isPlayer, isSubmit), date, customID);
        }

        public static Request AddCommanderCombatInterdiction(this Request request, CommanderCombatInterdiction eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("addCommanderCombatInterdiction", eventData, date, customID);
        }

        public static Request AddCommanderCombatInterdiction(this Request request, string starSystemName, string opponentName, bool isPlayer, bool? isSuccess = null, DateTime? date = null, int? customID = null)
        {
            return request.AddCommanderCombatInterdiction(new CommanderCombatInterdiction(starSystemName, opponentName, isPlayer, isSuccess), date, customID);
        }

        public static Request AddCommanderCombatInterdictionEscape(this Request request, CommanderCombatInterdictionEscape eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("addCommanderCombatInterdictionEscape", eventData, date, customID);
        }

        public static Request AddCommanderCombatInterdictionEscape(this Request request, string starSystemName, string opponentName, bool isPlayer, DateTime? date = null, int? customID = null)
        {
            return request.AddCommanderCombatInterdictionEscape(new CommanderCombatInterdictionEscape(starSystemName, opponentName, isPlayer), date, customID);
        }

        public static Request AddCommanderCombatKill(this Request request, CommanderCombatKill eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("addCommanderCombatKill", eventData, date, customID);
        }

        public static Request AddCommanderCombatKill(this Request request, string starSystemName, string opponentName, DateTime? date = null, int? customID = null)
        {
            return request.AddCommanderCombatKill(new CommanderCombatKill(starSystemName, opponentName), date, customID);
        }

        public static Request GetCommunityGoalsRecent(this Request request, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("getCommunityGoalsRecent", new Dictionary<string, string>(), date, customID);
        }

        public static Request SetCommanderCommunityGoalProgress(this Request request, CommanderCommunityGoalProgress eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("setCommanderCommunityGoalProgress", eventData, date, customID);
        }

        public static Request SetCommanderCommunityGoalProgress(this Request request,
            int communityGoalGameID, int contribution, int percentileBand, int percentileBandReward, bool? isTopRank = null,
            DateTime? date = null, int? customID = null)
        {
            return request.SetCommanderCommunityGoalProgress(new CommanderCommunityGoalProgress(communityGoalGameID, contribution, percentileBand, percentileBandReward, isTopRank), date, customID);
        }

        public static Request SetCommunityGoal(this Request request, CommunityGoal eventData, DateTime? date = null, int? customID = null)
        {
            return request.AddEvent("setCommunityGoal", eventData, date, customID);
        }

        public static Request SetCommunityGoal(this Request request,
            int communityGoalGameID, string communityGoalName, string starSystemName, string stationName,
            DateTime goalExpiry, int? tierReached = null, int? tierMax = null, int? topRankSize = null, bool? isCompleted = null,
            int? contributorsNum = null, int? contributionsTotal = null, string completionBonus = null,
            DateTime? date = null, int? customID = null)
        {
            return request.SetCommunityGoal(new CommunityGoal(
                    communityGoalGameID, communityGoalName, starSystemName, stationName,
                    goalExpiry, tierReached, tierMax, topRankSize, isCompleted,
                    contributorsNum, contributionsTotal, completionBonus),
                date, customID);
        }
    }
}
﻿using System;

namespace Smart_AI_Creator
{
    public enum action_type
    {
        NONE,
        TALK,
        SET_FACTION,
        MORPH_TO_ENTRY_OR_MODEL,
        SOUND,
        PLAY_EMOTE,
        FAIL_QUEST,
        ADD_QUEST,
        SET_REACT_STATE,
        ACTIVATE_GOBJECT,
        RANDOM_EMOTE,
        CAST,
        SUMMON_CREATURE,
        THREAT_SINGLE_PCT,
        THREAT_ALL_PCT,
        CALL_AREAEXPLOREDOREVENTHAPPENS,
        SEND_CASTCREATUREORGO,
        SET_EMOTE_STATE,
        SET_UNIT_FLAG,
        REMOVE_UNIT_FLAG,
        AUTO_ATTACK,
        ALLOW_COMBAT_MOVEMENT,
        SET_EVENT_PHASE,
        INC_EVENT_PHASE,
        EVADE,
        FLEE_FOR_ASSIST,
        CALL_GROUPEVENTHAPPENS,
        CALL_CASTEDCREATUREORGO,
        REMOVEAURASFROMSPELL,
        FOLLOW,
        RANDOM_PHASE,
        RANDOM_PHASE_RANGE,
        RESET_GOBJECT,
        CALL_KILLEDMONSTER,
        SET_INST_DATA,
        SET_INST_DATA64,
        UPDATE_TEMPLATE,
        DIE,
        SET_IN_COMBAT_WITH_ZONE,
        CALL_FOR_HELP,
        SET_SHEATH,
        FORCE_DESPAWN,
        SET_INVINCIBILITY_HP_LEVEL,
        MOUNT_TO_ENTRY_OR_MODEL,
        SET_INGAME_PHASE_MASK,
        SET_DATA,
        MOVE_FORWARD,
        SET_VISIBILITY,
        SET_ACTIVE,
        ATTACK_START,
        SUMMON_GO,
        KILL_UNIT,
        ACTIVATE_TAXI,
        WP_START,
        WP_PAUSE,
        WP_STOP,
        ADD_ITEM,
        REMOVE_ITEM,
        INSTALL_AI_TEMPLATE,
        SET_RUN,
        SET_FLY,
        SET_SWIM,
        TELEPORT,
        STORE_VARIABLE_DECIMAL,
        STORE_TARGET_LIST,
        WP_RESUME,
        SET_ORIENTATION,
        CREATE_TIMED_EVENT,
        PLAYMOVIE,
        MOVE_TO_POS,
        RESPAWN_TARGET,
        EQUIP,
        CLOSE_GOSSIP,
        TRIGGER_TIMED_EVENT,
        REMOVE_TIMED_EVENT,
        ADD_AURA,
        OVERRIDE_SCRIPT_BASE_OBJECT,
        RESET_SCRIPT_BASE_OBJECT,
        CALL_SCRIPT_RESET,
        ENTER_VEHICLE,
        CALL_TIMED_ACTIONLIST,
        SET_NPC_FLAG,
        ADD_NPC_FLAG,
        REMOVE_NPC_FLAG,
        SIMPLE_TALK,
        INVOKER_CAST,
        CROSS_CAST,
        CALL_RANDOM_TIMED_ACTIONLIST,
        CALL_RANDOM_RANGE_TIMED_ACTIONLIST,
        RANDOM_MOVE,
        SET_UNIT_FIELD_BYTES_1,
        REMOVE_UNIT_FIELD_BYTES_1,
        INTERRUPT_SPELL,
        SEND_GO_CUSTOM_ANIM,
        SET_DYNAMIC_FLAG,
        ADD_DYNAMIC_FLAG,
        REMOVE_DYNAMIC_FLAG
    };

    public enum event_type
    {
        TIMER = 0,
        TIMER_OOC = 1,
        HP = 2,
        MANA = 3,
        AGGRO = 4,
        KILL = 5,
        DEATH = 6,
        EVADE = 7,
        SPELLHIT = 8,
        RANGE = 9,
        OOC_LOS = 10,
        RESPAWN = 11,
        TARGET_HP = 12,
        TARGET_CASTING = 13,
        FRIENDLY_HP = 14,
        FRIENDLY_IS_CC = 15,
        FRIENDLY_MISSING_BUFF = 16,
        SUMMONED_UNIT = 17,
        TARGET_MANA = 18,
        ACCEPTED_QUEST = 19,
        REWARD_QUEST = 20,
        REACHED_HOME = 21,
        RECEIVE_EMOTE = 22,
        HAS_AURA = 23,
        TARGET_BUFFED = 24,
        RESET = 25,
        IC_LOS = 26,
        PASSENGER_BOARDED = 27,
        PASSENGER_REMOVED = 28,
        CHARMED = 29,
        CHARMED_TARGET = 30,
        SPELLHIT_TARGET = 31,
        DAMAGED = 32,
        DAMAGED_TARGET = 33,
        MOVEMENTINFORM = 34,
        SUMMON_DESPAWNED = 35,
        CORPSE_REMOVED = 36,
        AI_INIT = 37,
        DATA_SET = 38,
        WAYPOINT_START = 39,
        WAYPOINT_REACHED = 40,
        TRANSPORT_ADDPLAYER = 41,
        TRANSPORT_ADDCREATURE = 42,
        TRANSPORT_REMOVE_PLAYER = 43,
        TRANSPORT_RELOCATE = 44,
        INSTANCE_PLAYER_ENTER = 45,
        AREATRIGGER_ONTRIGGER = 46,
        QUEST_ACCEPTED = 47,
        QUEST_OBJ_COMPLETION = 48,
        QUEST_COMPLETION = 49,
        QUEST_REWARDED = 50,
        QUEST_FAIL = 51,
        TEXT_OVER = 52,
        RECEIVE_HEAL = 53,
        JUST_SUMMONED = 54,
        WAYPOINT_PAUSED = 55,
        WAYPOINT_RESUMED = 56,
        WAYPOINT_STOPPED = 57,
        WAYPOINT_ENDED = 58,
        TIMED_EVENT_TRIGGERED = 59,
        UPDATE = 60,
        LINK = 61,
        GOSSIP_SELECT = 62,
        JUST_CREATED = 63,
        GOSSIP_HELLO = 64,
        FOLLOW_COMPLETED = 65,
        DUMMY_EFFECT = 66,
    };

    public enum target_type
    {
        NONE = 0,
        SELF = 1,
        VICTIM = 2,
        HOSTILE_SECOND_AGGRO = 3,
        HOSTILE_LAST_AGGRO = 4,
        HOSTILE_RANDOM = 5,
        HOSTILE_RANDOM_NOT_TOP = 6,
        ACTION_INVOKER = 7,
        POSITION = 8,
        CREATURE_RANGE = 9,
        CREATURE_GUID = 10,
        CREATURE_DISTANCE = 11,
        STORED = 12,
        GAMEOBJECT_RANGE = 13,
        GAMEOBJECT_GUID = 14,
        GAMEOBJECT_DISTANCE = 15,
        INVOKER_PARTY = 16,
        PLAYER_RANGE = 17,
        PLAYER_DISTANCE = 18,
        CLOSEST_CREATURE = 19,
        CLOSEST_GAMEOBJECT = 20,
        CLOSEST_PLAYER = 21,
        ACTION_INVOKER_VEHICLE = 22,
        OWNER_OR_SUMMONER = 23,
        THREAT_LIST = 24,
    };

    public enum templates
    {
        BASIC = 0,
        CASTER = 1,
        TURRET = 2,
        PASSIVE = 3,
        CAGED_GO_PART = 4,
        CAGED_NPC_PART = 5
    };

    public enum source_type
    {
        CREATURE,
        GAMEOBJECT,
        AREATRIGGER,
        EVENT,
        GOSSIP,
        QUEST,
        SPELL,
        TRANSPORT,
        INSTANCE,
        TIMED_ACTIONLIST
    };

    public enum CastFlags
    {
        INTURRUPT_PREVIOUS  = 1,
        TRIGGERED           = 2,
        FORCE_CAST          = 4,
        NO_MELEE_IF_OOM     = 8,
        FORCE_TARGET_SELF   = 16,
        AURA_NOT_PRESENT    = 32,
    };

    public enum TargetFrends
    {
        Hostile = 0,
        Friendly = 1,
    };

    public enum Sheath
    {
        unarmed,
        melee,
        ranged
    };

    public enum ReactStates 
    {
        PASSIVE,
        DEFENSIVE,
        AGGRESSIVE
    };

    public enum SummonTypes 
    {
        TIMED_OR_DEAD_DESPAWN = 1,
        TIMED_OR_CORPSE_DESPAWN,
        TIMED_DESPAWN,
        TIMED_DESPAWN_OUT_OF_COMBAT,
        CORPSE_DESPAWN,
        CORPSE_TIMED_DESPAWN,
        DEAD_DESPAWN,
        MANUAL_DESPAWN,
    };
}
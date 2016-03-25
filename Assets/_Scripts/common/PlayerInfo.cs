/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;

public enum INFOTYPE
{
    BarInfo,
    PartyInfo,
    Time,
    Money,
    SurvivalDays,
    All
}

public class PlayerInfo : MonoBehaviour
{
    private static PlayerInfo _instance;
    public static PlayerInfo Instance{get {return _instance;}set { _instance = value;}}
    
    public string headIcon;
    public string playerName;
    public string workPlace;
    public string skillList;
    public string party;
    public string duty;
    public string jailRoomType;
    public string friendsList;
    public string enemyList;
    public string escapTeamList;
    public string victimList;
    public string achievementsList;

    public int happiness;
    public int energy;
    public int healthy;
    public int fame;
    public int power;
    public int agility;
    public int intelligence;
    public int charisma;
    public int luck;
    public int totalDays;
    public int survivalDays;
    public int fameInParty;
    public int money;
    public int release;// 0-未假释  1-听证会 2-取消听证会 3-已假释
    public int relationWithMobsters;
    public int relationWithCoin;
    public int relationWithRosesAndGuns;
    public int relationWithHeartBreakers;
    public int snicth;// 告密
    public int time;


    public delegate void OnPlayerInfoChanged(INFOTYPE type);
    public event OnPlayerInfoChanged OnPlayerInfoChangedEvent;
    
    void Awake()
    {
        _instance = this;
    }

    /// <summary>
    /// 初始化新人物
    /// </summary>
    /// <param name="model"></param>
    public void BeginNewGame(CharactorModel model)
    {
        playerName = model.roleName;
        workPlace = "b_all_work1";
        skillList = model.skillList;
        jailRoomType = "b_all_cell1";
        friendsList = null;
        enemyList = null;
        escapTeamList = null;
        victimList = null;
        achievementsList = null;
        party = null;
        duty = null;

        happiness = 100;
        energy = 100;
        healthy = 100;
        time = 6;
        money = 20;
        fame = 0;
        headIcon = model.bodyModel.headICONName;
        power = model.power;
        agility = model.agility;
        intelligence = model.intelligence;
        charisma = model.charisma;
        luck = model.luck;
        totalDays = model.prisonDays;
        survivalDays = 0;
        fameInParty = 0;
        release = 0; //  假释状态
        relationWithMobsters = 0;
        relationWithCoin = 0;
        relationWithRosesAndGuns = 0;
        relationWithHeartBreakers = 0;
        snicth = 0;
        
        OnPlayerInfoChangedEvent(INFOTYPE.All);
        SaveToPlayerprefs();
    }

    /// <summary>
    /// 从PlayerPrefs加载人物信息
    /// </summary>
    public void Load()
    {
        headIcon = PlayerPrefs.GetString("headIcon");
        playerName = PlayerPrefs.GetString("playerName");
        workPlace = PlayerPrefs.GetString("workPlace");
        skillList = PlayerPrefs.GetString("skillList");
        jailRoomType = PlayerPrefs.GetString("jailRoomType");
        friendsList = PlayerPrefs.GetString("friendsList");
        enemyList = PlayerPrefs.GetString("enemyList");
        escapTeamList = PlayerPrefs.GetString("escapTeamList");
        victimList = PlayerPrefs.GetString("victimList");
        achievementsList = PlayerPrefs.GetString("achievementsList");
        party = PlayerPrefs.GetString("party");
        duty = PlayerPrefs.GetString("duty");

        happiness = PlayerPrefs.GetInt("happiness");
        energy = PlayerPrefs.GetInt("energy");
        healthy = PlayerPrefs.GetInt("healthy");
        money = PlayerPrefs.GetInt("money");
        fame = PlayerPrefs.GetInt("fame");
        power = PlayerPrefs.GetInt("power");
        agility = PlayerPrefs.GetInt("agility");
        intelligence = PlayerPrefs.GetInt("intelligence");
        charisma = PlayerPrefs.GetInt("charisma");
        luck = PlayerPrefs.GetInt("luck");
        totalDays = PlayerPrefs.GetInt("totalDays");
        survivalDays = PlayerPrefs.GetInt("survivalDays");
        fameInParty = PlayerPrefs.GetInt("fameInParty");
        release = PlayerPrefs.GetInt("release");
        relationWithMobsters = PlayerPrefs.GetInt("relationWithMobsters");
        relationWithCoin = PlayerPrefs.GetInt("relationWithCoin");
        relationWithRosesAndGuns = PlayerPrefs.GetInt("relationWithRosesAndGuns");
        relationWithHeartBreakers = PlayerPrefs.GetInt("relationWithHeartBreakers");
        snicth = PlayerPrefs.GetInt("snicth");

        time = PlayerPrefs.GetInt("time");
        OnPlayerInfoChangedEvent(INFOTYPE.All);
    }

    /// <summary>
    /// 睡觉前写日记，保存数据
    /// </summary>
    /// <param name="model"></param>
    public void SaveToPlayerprefs()
    {
        PlayerPrefs.SetString("headIcon", headIcon);
        PlayerPrefs.SetString("playerName", playerName);
        PlayerPrefs.SetString("workPlace", workPlace);
        PlayerPrefs.SetString("skillList", skillList);
        PlayerPrefs.SetString("jailRoomType", jailRoomType);
        PlayerPrefs.SetString("friendsList", friendsList);
        PlayerPrefs.SetString("enemyList", enemyList);
        PlayerPrefs.SetString("escapTeamList", escapTeamList);
        PlayerPrefs.SetString("victimList", victimList);
        PlayerPrefs.SetString("achievementsList", achievementsList);
        PlayerPrefs.SetString("party", party);
        PlayerPrefs.SetString("duty", duty);

        PlayerPrefs.SetInt("happiness", happiness);
        PlayerPrefs.SetInt("energy", energy);
        PlayerPrefs.SetInt("healthy", healthy);
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("fame", fame);
        PlayerPrefs.SetInt("power", power);
        PlayerPrefs.SetInt("agility", agility);
        PlayerPrefs.SetInt("intelligence", intelligence);
        PlayerPrefs.SetInt("charisma", charisma);
        PlayerPrefs.SetInt("luck", luck);
        PlayerPrefs.SetInt("totalDays", totalDays);
        PlayerPrefs.SetInt("survivalDays", survivalDays);
        PlayerPrefs.SetInt("fameInParty", fameInParty);
        PlayerPrefs.SetInt("release", release);
        PlayerPrefs.SetInt("relationWithMobsters", relationWithMobsters);
        PlayerPrefs.SetInt("relationWithCoin", relationWithCoin);
        PlayerPrefs.SetInt("relationWithRosesAndGuns", relationWithRosesAndGuns);
        PlayerPrefs.SetInt("relationWithHeartBreakers", relationWithHeartBreakers);
        PlayerPrefs.SetInt("snicth", snicth);
        PlayerPrefs.SetInt("time", time);
    }

    public void EnergyChange(int point)
    {
        energy += point;
        if (energy < 0)
            energy = 0;
        else if (energy > 100)
            energy = 100;

        OnPlayerInfoChangedEvent(INFOTYPE.BarInfo);
    }
    
    public void DaySurvivalChange()
    {
        survivalDays += 1;
        OnPlayerInfoChangedEvent(INFOTYPE.SurvivalDays);
    }
}
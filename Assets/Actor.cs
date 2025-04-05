using UnityEngine;

public class Actor
{
    int id;
    string name;
    string title;
    string weapon;
    float strength;
    int level;

    string Talk()
    {
        return "대화를 걸었습니다.";
    }

    string HasWeapon()
    {
        return weapon;
    }

    void LevelUp()
    {
        level = level + 1;
    }
}

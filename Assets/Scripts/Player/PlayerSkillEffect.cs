using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkillEffect : MonoBehaviour
{
    [Header("Skill Efects")]
    public GameObject HamerSkill;
    public GameObject KickSkill;
    public GameObject SpellCastSkill;
    public GameObject HealSkill;
    public GameObject ShieldSkill;
    public GameObject ComboSkill;
    [Header("Skill Transform")]
    public Transform KickTransform;
    public Transform SpeelCastTransform;
    public Transform HamerSkillTransform;
    public Transform ComboSkillTransform;

    void HamerSkillCast()
    {
        Instantiate(HamerSkill, HamerSkillTransform.position,Quaternion.identity);
    }

    void KickSpelCast()
    {
        Instantiate(KickSkill, KickTransform.position, Quaternion.identity);
    }
    void SpellCast()
    {
        Instantiate(SpellCastSkill, SpeelCastTransform.position, Quaternion.identity);
    }
    void SlashComboCast()
    {
        Instantiate(ComboSkill, ComboSkillTransform.position, Quaternion.identity);
    }
    void ShieldCast()
    {
        Vector3 pos = transform.position;
        Instantiate(ShieldSkill, pos, Quaternion.identity);
    }
    void HealCast()
    {
        Vector3 pos = transform.position;
        Instantiate(HealSkill, pos, Quaternion.identity);
    }
}

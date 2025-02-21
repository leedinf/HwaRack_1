using UnityEngine;

[CreateAssetMenu(fileName = "SkillData", menuName = "SkillData", order = 0)]
public class SkillData : ScriptableObject {
    public string skillName;
    public float damage;
    public float cooldown;
    public Sprite icon;
    public GameObject effectPrefab;  // 사용 시 표시할 이펙트
    // 필요하다면 더 많은 속성 추가 (마나 소모량, 범위, 사운드, 상태이상 등)
}

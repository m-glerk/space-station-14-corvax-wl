using Content.Shared._Offbrand.Wounds;
using Content.Shared.EntityConditions;
using Content.Shared.FixedPoint;
using Robust.Shared.Prototypes;

namespace Content.Shared._Offbrand.EntityEffects;

public sealed partial class HeartDamageCondition : EntityConditionBase<HeartDamageCondition>
{
    [DataField]
    public FixedPoint2 Max = FixedPoint2.MaxValue;

    [DataField]
    public FixedPoint2 Min = FixedPoint2.Zero;

    public override string EntityConditionGuidebookText(IPrototypeManager prototype)
    {
        var tMax = Max == FixedPoint2.MaxValue ? (float) int.MaxValue : Max.Float();
        var locMax = string.Format("{0:2}", tMax).Replace('.', ',').TrimEnd('0').TrimEnd(',');
        var locMin = string.Format("{0:2}", Min.Float()).Replace('.', ',').TrimEnd('0').TrimEnd(',');
        return Loc.GetString("effect-condition-guidebook-heart-damage",
            ("max", Max == FixedPoint2.MaxValue ? (float) int.MaxValue : Max.Float()),
            ("min", Min.Float()),
            ("locMin", locMin),
            ("locMax", locMax));
    }
}

public sealed class HeartDamageEntityConditionSystem : EntityConditionSystem<HeartrateComponent, HeartDamageCondition>
{
    protected override void Condition(Entity<HeartrateComponent> ent, ref EntityConditionEvent<HeartDamageCondition> args)
    {
        args.Result = ent.Comp.Damage >= args.Condition.Min && ent.Comp.Damage <= args.Condition.Max;
    }
}

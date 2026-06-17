using Content.Shared._Offbrand.Wounds;
using Content.Shared.EntityConditions;
using Content.Shared.FixedPoint;
using Robust.Shared.Prototypes;

namespace Content.Shared._Offbrand.EntityEffects;

public sealed partial class LungDamageCondition : EntityConditionBase<LungDamageCondition>
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
        return Loc.GetString("entity-condition-guidebook-lung-damage",
            ("max", Max == FixedPoint2.MaxValue ? (float) int.MaxValue : Max.Float()),
            ("min", Min.Float()),
            ("locMin", locMin),
            ("locMax", locMax));
    }
}

public sealed class LungDamageConditionEntitySystem : EntityConditionSystem<LungDamageComponent, LungDamageCondition>
{
    protected override void Condition(Entity<LungDamageComponent> ent, ref EntityConditionEvent<LungDamageCondition> args)
    {
        args.Result = ent.Comp.Damage >= args.Condition.Min && ent.Comp.Damage <= args.Condition.Max;
    }
}

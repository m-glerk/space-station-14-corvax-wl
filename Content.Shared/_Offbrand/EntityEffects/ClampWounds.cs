using Content.Shared._Offbrand.Wounds;
using Content.Shared.EntityEffects;
using Content.Shared.FixedPoint;
using Robust.Shared.Prototypes;

namespace Content.Shared._Offbrand.EntityEffects;

public sealed partial class ClampWounds : EntityEffectBase<ClampWounds>
{
    [DataField(required: true)]
    public float Chance;

    public override string? EntityEffectGuidebookText(IPrototypeManager prototype, IEntitySystemManager entSys)
    {
        var locChance = string.Format("{0:2}", Chance*100).Replace('.', ',').TrimEnd('0').TrimEnd(',') + "%";
        return Loc.GetString("entity-effect-guidebook-clamp-wounds", ("probability", Probability), ("chance", locChance));
    }
}

public sealed partial class ClampWoundsEntityEffectSystem : EntityEffectSystem<WoundableComponent, ClampWounds>
{
    [Dependency] private WoundableSystem _woundable = default!;

    protected override void Effect(Entity<WoundableComponent> ent, ref EntityEffectEvent<ClampWounds> args)
    {
        _woundable.ClampWounds(ent, args.Effect.Chance);
    }
}

using Content.Shared.EntityEffects;
using Content.Shared.Mind.Components;
using Content.Shared.Mind;
using Robust.Shared.Prototypes;
using Robust.Shared.Player;

namespace Content.Shared._WL._Offbrand.EntityEffects.Effects;

/// <summary>
/// Makes this entity emote.
/// </summary>
/// <inheritdoc cref="EntityEffectSystem{T,TEffect}"/>
public sealed partial class ForceReturnToBodyEntityEffectSystem : EntityEffectSystem<MindContainerComponent, ForceReturnToBody>
{
    [Dependency] private SharedMindSystem _mind = default!;
    [Dependency] private ISharedPlayerManager _player = default!;

    protected override void Effect(Entity<MindContainerComponent> ent, ref EntityEffectEvent<ForceReturnToBody> args)
    {
        if (_mind.TryGetMind(ent, out var mindUid, out var mindComp) &&
            _player.TryGetSessionById(mindComp.UserId, out var playerSession))
        {
            if (mindComp.CurrentEntity != ent)
                _mind.UnVisit(playerSession);
        }
    }
}

/// <inheritdoc cref="EntityEffect"/>
public sealed partial class ForceReturnToBody : EntityEffectBase<ForceReturnToBody>
{
    /// <summary>
    ///     If the forced emote will be listed in the guidebook.
    /// </summary>
    [DataField]
    public bool ShowInGuidebook;

    public override string? EntityEffectGuidebookText(IPrototypeManager prototype, IEntitySystemManager entSys)
    {
        if (!ShowInGuidebook)
            return null;

        return Loc.GetString("entity-effect-guidebook-force-return", ("chance", Probability));
    }
}

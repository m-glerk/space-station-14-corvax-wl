using Content.Shared.MedicalScanner;

namespace Content.Client.HealthAnalyzer.UI.Tooltips;

public sealed partial class RespiratoryRateTooltip : UpdatableTooltip
{
    public override void Update(HealthAnalyzerUiState msg)
    {
        if (msg.WoundableData is not { } woundable)
            return;

        Label.Text = Loc.GetString("health-analyzer-respiratory-rate-tooltip", ("etco2gas", Loc.GetString(woundable.Etco2GasName)), ("etco2", Loc.GetString(woundable.Etco2Name)), ("spo2gas", Loc.GetString(woundable.Spo2GasName)), ("spo2", Loc.GetString(woundable.Spo2Name)));
    }
}

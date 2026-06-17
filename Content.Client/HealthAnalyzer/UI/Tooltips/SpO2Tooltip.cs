using Content.Shared.MedicalScanner;

namespace Content.Client.HealthAnalyzer.UI.Tooltips;

public sealed partial class SpO2Tooltip : UpdatableTooltip
{
    public override void Update(HealthAnalyzerUiState msg)
    {
        if (msg.WoundableData is not { } woundable)
            return;

        Label.Text = Loc.GetString("health-analyzer-spo2-tooltip", ("gas", Loc.GetString(woundable.Spo2GasName)), ("spo2", Loc.GetString(woundable.Spo2Name)));
    }
}

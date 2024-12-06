using Content.Shared.Atmos;
using Content.Shared.Guidebook;

namespace Content.Server.Atmos.Portable
{
    [RegisterComponent]
    public sealed partial class PortableScrubberComponent : Component
    {
        /// <summary>
        /// The air inside this machine.
        /// </summary>
        [DataField("gasMixture"), ViewVariables(VVAccess.ReadWrite)]
        public GasMixture Air { get; private set; } = new();

        [DataField("port"), ViewVariables(VVAccess.ReadWrite)]
        public string PortName { get; set; } = "port";

        /// <summary>
        /// Which gases this machine will scrub out.
        /// Unlike fixed scrubbers controlled by an air alarm,
        /// this can't be changed in game.
        /// </summary>
        [DataField("filterGases")]
        public HashSet<Gas> FilterGases = new()
        {
            Gas.CarbonDioxide,
            Gas.Plasma,
            Gas.Tritium,
            Gas.WaterVapor,
            Gas.Ammonia,
            Gas.NitrousOxide,
            Gas.Frezon,
<<<<<<< HEAD
            Gas.InfectionDeadSpace
=======
            Gas.BZ,
            Gas.Healium,
            Gas.Nitrium,
>>>>>>> 144551ba8f (add some /tg/ gases to goob)
        };

        [ViewVariables(VVAccess.ReadWrite)]
        public bool Enabled = true;

        /// <summary>
        /// Maximum internal pressure before it refuses to take more.
        /// </summary>
        [DataField, ViewVariables(VVAccess.ReadWrite)]
        public float MaxPressure = 2500;

        /// <summary>
        /// The speed at which gas is scrubbed from the environment.
        /// </summary>
        [DataField, ViewVariables(VVAccess.ReadWrite)]
        public float TransferRate = 800;

        #region GuidebookData

        [GuidebookData]
        public float Volume => Air.Volume;

        #endregion
    }
}

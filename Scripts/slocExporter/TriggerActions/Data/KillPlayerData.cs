﻿using System.IO;
using slocExporter.TriggerActions.Enums;
using UnityEngine;

namespace slocExporter.TriggerActions.Data {

    public sealed class KillPlayerData : BaseTriggerActionData {

        public override TargetType PossibleTargets => TargetType.Player;

        public override TriggerActionType ActionType => TriggerActionType.KillPlayer;

        [field: SerializeField]
        public string Cause { get; set; }

        public KillPlayerData(string cause) => Cause = cause;

        protected override void WriteData(BinaryWriter writer) => writer.Write(Cause);

    }

}

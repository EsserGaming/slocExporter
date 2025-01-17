﻿using slocExporter.TriggerActions.Enums;
using UnityEngine;

namespace slocExporter.TriggerActions.Data {

    public sealed class TeleportToPositionData : BaseTeleportData {

        public override TargetType PossibleTargets => TargetType.All;

        public override TriggerActionType ActionType => TriggerActionType.TeleportToPosition;

        public TeleportToPositionData(Vector3 position) => Position = position;

    }

}

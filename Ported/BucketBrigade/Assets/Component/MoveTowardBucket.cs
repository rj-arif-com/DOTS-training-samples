﻿using Unity.Entities;
using Unity.Transforms;

[GenerateAuthoringComponent]
public struct MoveTowardBucket: IComponentData
{
    Translation position;
}
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace CleanArchitecture.Blazor.Application.Features.KeyValues.DTOs;

public partial class KeyValueDto : IMapFrom<KeyValue>
{

    public int Id { get; set; }
    public Picklist Name { get; set; }
    public string? Value { get; set; }
    public string? Text { get; set; }
    public string? Description { get; set; }
    public TrackingState TrackingState { get; set; } = TrackingState.Unchanged;
}

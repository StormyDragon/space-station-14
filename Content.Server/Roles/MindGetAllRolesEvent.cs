﻿using Content.Shared.Players.PlayTimeTracking;

namespace Content.Server.Roles;

/// <summary>
///     Event raised on a mind entity to get all roles that a player has.
/// </summary>
/// <param name="Roles">The list of roles on the player.</param>
[ByRefEvent]
public readonly record struct MindGetAllRolesEvent(List<RoleInfo> Roles);

/// <summary>
///     Returned by <see cref="MindGetAllRolesEvent"/> to give some information about a player's role.
/// </summary>
/// <param name="Component">Role component associated with the mind entity id.</param>
/// <param name="Name">Name of the role.</param>
/// <param name="Antagonist">Whether or not this role makes this player an antagonist.</param>
/// <param name="PlayTimeTrackerId">The <see cref="PlayTimeTrackerPrototype"/> id associated with the role.</param>
public readonly record struct RoleInfo(Component Component, string Name, bool Antagonist, string? PlayTimeTrackerId);

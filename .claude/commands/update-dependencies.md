---
name: update-dependencies
description: Workflow command scaffold for update-dependencies in SysBot.German.
allowed_tools: ["Bash", "Read", "Write", "Grep", "Glob"]
---

# /update-dependencies

Use this workflow when working on **update-dependencies** in `SysBot.German`.

## Goal

Updates all project dependencies to the latest versions, including PKHeX, ALM, and related DLLs.

## Common Files

- `SysBot.Pokemon.Discord/SysBot.Pokemon.Discord.csproj`
- `SysBot.Pokemon.Twitch/SysBot.Pokemon.Twitch.csproj`
- `SysBot.Pokemon.WinForms/SysBot.Pokemon.WinForms.csproj`
- `SysBot.Pokemon.YouTube/SysBot.Pokemon.YouTube.csproj`
- `SysBot.Pokemon.Z3/SysBot.Pokemon.Z3.csproj`
- `SysBot.Pokemon/SysBot.Pokemon.csproj`

## Suggested Sequence

1. Understand the current state and failure mode before editing.
2. Make the smallest coherent change that satisfies the workflow goal.
3. Run the most relevant verification for touched files.
4. Summarize what changed and what still needs review.

## Typical Commit Signals

- Update all *.csproj files for each platform (Discord, Twitch, WinForms, YouTube, Z3, Base, Tests, etc.)
- Replace DLLs in deps/ (e.g., PKHeX.Core.AutoMod.dll, PKHeX.Drawing.dll, PKHeX.Drawing.PokeSprite.dll)
- Optionally update helper files if dependency APIs changed (e.g., AutoLegalityWrapper.cs)
- Commit with a message indicating the new dependency version

## Notes

- Treat this as a scaffold, not a hard-coded script.
- Update the command if the workflow evolves materially.
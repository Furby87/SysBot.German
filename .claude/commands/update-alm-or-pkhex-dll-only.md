---
name: update-alm-or-pkhex-dll-only
description: Workflow command scaffold for update-alm-or-pkhex-dll-only in SysBot.German.
allowed_tools: ["Bash", "Read", "Write", "Grep", "Glob"]
---

# /update-alm-or-pkhex-dll-only

Use this workflow when working on **update-alm-or-pkhex-dll-only** in `SysBot.German`.

## Goal

Updates only the PKHeX.Core.AutoMod.dll (ALM) or related DLLs, often for hotfixes or minor feature support.

## Common Files

- `SysBot.Pokemon/deps/PKHeX.Core.AutoMod.dll`
- `SysBot.Pokemon.WinForms/deps/PKHeX.Drawing.dll`
- `SysBot.Pokemon.WinForms/deps/PKHeX.Drawing.PokeSprite.dll`

## Suggested Sequence

1. Understand the current state and failure mode before editing.
2. Make the smallest coherent change that satisfies the workflow goal.
3. Run the most relevant verification for touched files.
4. Summarize what changed and what still needs review.

## Typical Commit Signals

- Replace PKHeX.Core.AutoMod.dll (and sometimes PKHeX.Drawing.dll) in the deps/ folder
- Commit with a message referencing the ALM/PKHeX update

## Notes

- Treat this as a scaffold, not a hard-coded script.
- Update the command if the workflow evolves materially.
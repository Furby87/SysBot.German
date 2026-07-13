```markdown
# SysBot.German Development Patterns

> Auto-generated skill from repository analysis

## Overview

This skill teaches you the core development patterns, coding conventions, and maintenance workflows for the SysBot.German codebase. SysBot.German is a C# project for automating Pokémon trades and related tasks across multiple platforms (Discord, Twitch, WinForms, YouTube, Z3). The repository is organized into platform-specific projects and game-specific logic, with a focus on modularity and maintainability. This guide covers file organization, code style, dependency management, UI updates, and multi-bot logic fixes.

## Coding Conventions

**File Naming**
- Use PascalCase for all file and class names.
  - Example: `PokeTradeBotBS.cs`, `Main.Designer.cs`

**Import Style**
- Use relative imports within the project.
  - Example:
    ```csharp
    using SysBot.Pokemon.BDSP.BotTrade;
    ```

**Export Style**
- Use named exports for classes and members.
  - Example:
    ```csharp
    public class PokeTradeBotBS { ... }
    ```

**Commit Messages**
- Freeform style, typically short and descriptive (average ~38 characters).
- Prefixes are not enforced.

## Workflows

### Update Dependencies
**Trigger:** When you need to update all project dependencies (e.g., PKHeX, ALM, DLLs) to their latest versions.  
**Command:** `/update-dependencies`

1. Update all `*.csproj` files for each platform:
   - `SysBot.Pokemon.Discord/SysBot.Pokemon.Discord.csproj`
   - `SysBot.Pokemon.Twitch/SysBot.Pokemon.Twitch.csproj`
   - `SysBot.Pokemon.WinForms/SysBot.Pokemon.WinForms.csproj`
   - `SysBot.Pokemon.YouTube/SysBot.Pokemon.YouTube.csproj`
   - `SysBot.Pokemon.Z3/SysBot.Pokemon.Z3.csproj`
   - `SysBot.Pokemon/SysBot.Pokemon.csproj`
   - `SysBot.Base/SysBot.Base.csproj`
   - `SysBot.Tests/SysBot.Tests.csproj`
2. Replace DLLs in the `deps/` directories:
   - `PKHeX.Core.AutoMod.dll`
   - `PKHeX.Drawing.dll`
   - `PKHeX.Drawing.PokeSprite.dll`
3. If dependency APIs changed, update helper files (e.g., `AutoLegalityWrapper.cs`).
4. Commit with a message indicating the new dependency version.

### Update ALM or PKHeX DLL Only
**Trigger:** When you need to hotfix or update only the PKHeX.Core.AutoMod.dll (ALM) or related DLLs.  
**Command:** `/update-alm`

1. Replace `PKHeX.Core.AutoMod.dll` (and optionally `PKHeX.Drawing.dll`) in the `deps/` folder.
   - Example:
     - `SysBot.Pokemon/deps/PKHeX.Core.AutoMod.dll`
     - `SysBot.Pokemon.WinForms/deps/PKHeX.Drawing.dll`
2. Commit with a message referencing the ALM/PKHeX update.

### Multi-Bot TradeBot Fix
**Trigger:** When you want to apply a bugfix or feature to all PokeTradeBot classes for multiple games (BDSP, LA, SV, SWSH).  
**Command:** `/fix-all-tradebots`

1. Edit the following files:
   - `SysBot.Pokemon/BDSP/BotTrade/PokeTradeBotBS.cs`
   - `SysBot.Pokemon/LA/BotTrade/PokeTradeBotLA.cs`
   - `SysBot.Pokemon/SV/BotTrade/PokeTradeBotSV.cs`
   - `SysBot.Pokemon/SWSH/BotTrade/PokeTradeBotSWSH.cs`
2. Optionally update related helpers or notifier files.
3. Commit with a message referencing trade or species logic.

### WinForms UI Main Designer Update
**Trigger:** When you need to update or fix the main application window's layout or behavior in WinForms.  
**Command:** `/update-main-ui`

1. Edit `Main.Designer.cs` (and sometimes `Main.cs`, `Main.resx`):
   - `SysBot.Pokemon.WinForms/Main.Designer.cs`
   - `SysBot.Pokemon.WinForms/Main.cs`
   - `SysBot.Pokemon.WinForms/Main.resx`
2. Optionally update related WinForms controls or config files.
3. Commit with a message referencing UI, design, or window.

## Testing Patterns

- Test files follow the `*Tests.cs` naming pattern.
- The specific test framework is unknown, but tests are likely organized per feature or module.
- Example test file: `SysBot.Tests/TradeBotTests.cs`

## Commands

| Command               | Purpose                                                         |
|-----------------------|-----------------------------------------------------------------|
| /update-dependencies  | Update all project dependencies and DLLs to latest versions     |
| /update-alm           | Update only PKHeX.Core.AutoMod.dll (ALM) or related DLLs       |
| /fix-all-tradebots    | Apply a fix or feature to all PokeTradeBot classes at once     |
| /update-main-ui       | Update or fix the main WinForms application window             |
```
# Gravity Shifter

Archive of the **Gravity Shifter** prototype (working title *Night Owls: Gravity Invasion*) — a small
Unity experiment where the player can rotate world gravity 90° at a time and walk on the walls.

> **Status:** Playable **team prototype** — a group project, not a finished/shipped game. The core
> gravity-shift mechanic works in the Unity editor; menus, levels, audio, and a packaged build are not
> implemented.

## 🎥 Gameplay video

A short (40-second) clip of the gravity-shift mechanic in action:

https://github.com/user-attachments/assets/396f8917-3b6b-49ae-9c73-91bade1f12c0

The **full-quality** 9.6-minute capture (`Game/NightOwls_GravityInvasion_Gameplay-001.mp4`, ~2.7 GB) is
**not stored in git** — it exceeds GitHub's 100 MB per-file limit and is listed in
[`.gitignore`](.gitignore). The short clip above is hosted on GitHub's attachment CDN (uploaded via an
issue) so it plays inline; for the full video, host it externally (e.g. YouTube) and link it here.

## What's in here

```
GT_archive/
├─ Game/
│  ├─ NightOwls_GravityInvasion_Gameplay-001.mp4   # gameplay capture (git-ignored, ~2.7 GB)
│  └─ GravityShifter_v2/                            # the Unity project
│     ├─ Assets/       # scenes, scripts, materials, Y_Bot model + animations
│     ├─ Packages/     # package manifest + lockfile
│     └─ ProjectSettings/
```

## Running the project

**Unity version: `2020.3.38f1`** (pinned in
[`Game/GravityShifter_v2/ProjectSettings/ProjectVersion.txt`](Game/GravityShifter_v2/ProjectSettings/ProjectVersion.txt)).

1. Install **Unity 2020.3.38f1** (via Unity Hub → *Installs* → *Archive*). A newer version will still
   open it but will run a one-way API upgrade.
2. In Unity Hub, **Add** the folder `Game/GravityShifter_v2`.
3. Open it — Unity regenerates `Library/` on first launch (this can take a minute).
4. Open **`Assets/Scenes/SampleScene.unity`** and press **Play**.

> Note: the scene is **not** in *Build Settings*, so it runs in the editor but a built player would be
> empty. Add `SampleScene` under *File → Build Settings* before building.

## Controls

| Key       | Action                                  |
|-----------|-----------------------------------------|
| `W`/`A`/`S`/`D` (arrows) | Move                      |
| `Space`   | Jump                                    |
| `R`       | Rotate gravity 90° clockwise            |
| `L`       | Rotate gravity 90° counter-clockwise    |

Movement/jump/gravity live in
[`Assets/Scripts/PlayerController.cs`](Game/GravityShifter_v2/Assets/Scripts/PlayerController.cs);
the Y_Bot animation triggers (`W`/`A`/`D`/`E`) are in
[`Assets/new_Movement.cs`](Game/GravityShifter_v2/Assets/new_Movement.cs).

## Status

Old prototype (last touched Sept 2022), archived as-is. Self-contained — no external assets or textures
are referenced beyond what's in `Assets/`.

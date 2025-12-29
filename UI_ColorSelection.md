# UI – Color Selection (Version 1.0)

This document describes the mobile UI for selecting item colors.
Designed for portrait mode and touch controls.

## Screen Layout

- Title at top: "Color Machine"
- Currency display under title (coins)
- Main color grid in center
- Color info panel at bottom
- Action buttons at bottom

## Color Grid

- Grid size: 4 x 4
- Total buttons: 16 (one per color)
- Large square buttons for easy tapping
- Each button shows:
  - Color preview
  - Rarity border
  - Lock icon if locked

## Rarity Visuals

### Common
- Gray border
- No glow

### Uncommon
- Blue border
- Very soft glow

### Rare
- Purple border
- Slow pulse glow

### Very Rare
- Gold border
- Strong glow
- Small particles

### Legendary (Rainbow)
- Animated rainbow border
- Strong glow
- Sparkle particles

## Color Info Panel

Shows when a color is selected:
- Color name
- Rarity text
- Short description

Example:
Name: GOLD
Rarity: VERY RARE

## Buttons

- APPLY
  - Enabled when color is unlocked
  - Disabled when locked
- BACK
  - Returns to previous screen

## Interaction Rules

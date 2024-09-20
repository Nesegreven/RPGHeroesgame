# RPG Heroes

RPG Heroes is a C# class library that implements a simple role-playing game (RPG) system. It includes various hero classes, items, and game mechanics.

## Project Structure

The project consists of the following main components:

1. **Hero Classes**: 
   - `Hero` (abstract base class)
   - `Mage`
   - `Ranger`
   - `Rogue`
   - `Warrior`

2. **Item Classes**:
   - `Item` (abstract base class)
   - `Weapon`
   - `Armor`

3. **Attribute System**:
   - `HeroAttribute` (represents Strength, Dexterity, and Intelligence)

4. **Enumerations**:
   - `Slot` (equipment slots)
   - `WeaponType`
   - `ArmorType`

5. **Utilities**:
   - `ItemGenerator` (generates a list of predefined items)
   - `EquipItemsDemo` (demonstrates the functionality of equipping items)

6. **Custom Exceptions**:
   - `InvalidWeaponException`
   - `InvalidArmorException`

## Features

- Four hero classes with unique attributes and equipment preferences
- Equipment system with weapons and armor
- Level-up mechanics
- Damage calculation based on hero attributes and equipment
- Custom exceptions for invalid equipment operations

## Requirements

To build and run this project, you'll need one of the following development environments:

### Option 1: Visual Studio Code
- [Visual Studio Code](https://code.visualstudio.com/)
- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)

### Option 2: Visual Studio (Windows)
Choose one of the following versions:

**Visual Studio Community 2022**
- Free for individual developers, open source projects, academic research, education, and small professional teams.
- [Download Visual Studio Community](https://visualstudio.microsoft.com/vs/community/)

**Visual Studio Professional 2022**
- For professional developers and small teams.
- [Download Visual Studio Professional](https://visualstudio.microsoft.com/vs/professional/)

**Visual Studio Enterprise 2022**
- For enterprise-scale development and testing.
- [Download Visual Studio Enterprise](https://visualstudio.microsoft.com/vs/enterprise/)

Ensure that you have the ".NET Desktop Development" workload installed with your Visual Studio installation.

### Additional Requirements
- .NET 6.0 SDK (included in Visual Studio 2022 installations)

Make sure to select the appropriate version based on your needs and licensing requirements. All versions will be capable of building and running this project.

## Demo

The `EquipItemsDemo` class provides a demonstration of the system's functionality. You can run it from the `Main` method in the `Program` class:

```csharp
EquipItemsDemo.Run();
```

This will create a hero, generate items, attempt to equip them, level up the hero, and display the hero's state at various points.

## Contributing

Contributions to improve RPG Heroes are welcome. Please feel free to submit pull requests or open issues to discuss potential changes or additions.

## License

[Specify your license here, e.g., MIT License, GPL, etc.]


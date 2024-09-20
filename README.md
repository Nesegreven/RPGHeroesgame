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

## How to Use

1. Create a hero:
   ```csharp
   Hero hero = new Warrior("Aragon");
   ```

2. Generate items:
   ```csharp
   List<Item> items = ItemGenerator.GenerateItems();
   ```

3. Equip items to the hero:
   ```csharp
   try
   {
       hero.Equip(weapon);
       hero.Equip(armor);
   }
   catch (InvalidWeaponException e)
   {
       Console.WriteLine(e.Message);
   }
   catch (InvalidArmorException e)
   {
       Console.WriteLine(e.Message);
   }
   ```

4. Level up the hero:
   ```csharp
   hero.LevelUp();
   ```

5. Display hero information:
   ```csharp
   Console.WriteLine(hero.Display());
   ```

## Demo

The `EquipItemsDemo` class provides a demonstration of the system's functionality. You can run it from the `Main` method in the `Program` class:

```csharp
EquipItemsDemo.Run();
```

This will create a hero, generate items, attempt to equip them, level up the hero, and display the hero's state at various points.

## Extending the Project

To add new features or modify existing ones:

1. To add a new hero class, create a new class that inherits from `Hero` and implement the abstract methods.
2. To add new item types, extend the `Item` class and update the `ItemGenerator` class.
3. To modify hero attributes or leveling mechanics, update the relevant hero classes.

## Contributing

Contributions to improve RPG Heroes are welcome. Please feel free to submit pull requests or open issues to discuss potential changes or additions.

## License

[Specify your license here, e.g., MIT License, GPL, etc.]


Made by Carl Ericsson.

About:
Very boring shooter. Kill enemies to gain points and achievements.
Enemies spawn in a wave every 10 seconds.
WASD to move, left click to shoot.
You can undo your movement by holding F.

Patterns used:
- Singleton, in 'ScoreManager.cs'
Used to keep track of the player's score and allows global access to it.

- Pool, in 'BulletPool.cs'. 
Pools bullets for the player's weapon.

- Factory, 'EnemyFactory.cs' and 'BaseEnemy.cs'.
BaseEnemy is the abstract class that is used by the EnemyFactory to instantiate enemies.
Currently the EnemySpawner is using the factory to randomise enemies spawned.

- Observer, in 'ScoreManager.cs' and 'ScorePanel.cs'.
ScorePanel subscribes to the ScoreManager's event for UI updates.
AchievementManager subscribes to ScoreManager for varius Achievement conditions.

- Command, in 'Command.cs', 'CommandProcessor.cs', 'MoveCommand.cs'.
Saves the players move commands.
In this game undoing doesn't really serve any purpose.
Made by Carl Ericsson.

About:
Very boring shooter. Kill enemies to gain points and achievements.
Enemies spawn in a wave every 10 seconds.
Last wave is a boss wave.
WASD to move, left click to shoot.

Patterns used:
- Singleton, in 'ScoreManager.cs'
Used to keep track of the player's score and allows global access to it.

- Pool, in 'BulletPool.cs'. 
Pools bullets for the player's weapon.

- Factory, 'EnemyFactory.cs' and 'BaseEnemy.cs'.
BaseEnemy is the abstract class that is used by the EnemyFactory to instantiate enemies.
Currently the EnemySpawner is using the factory to randomise enemies spawned.

- 
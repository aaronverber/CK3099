public static class GameEventManager{

	public delegate void GameEvent();

	public static event GameEvent EnemyDestroyed;

	public static void TriggerEnemyDestroyed(){
		if(EnemyDestroyed != null){
			EnemyDestroyed();
		}
	}
}
function GameConnection::onConnectionTimedOut(%this)
{

echo("Game connection timed out.");

schedule(0,0,"Dots_and_Crits::Game_Connection_Delete",Dots_and_Crits,$GameConnection_Master_Server_Query);

$GameConnection_Master_Server_Query=0;

}

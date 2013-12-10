function GameConnection::onConnectRequestTimedOut(%this)
{

echo("Game connection request timed out.");

schedule(0,0,"Dots_and_Crits::Game_Connection_Delete",Dots_and_Crits,$GameConnection_Master_Server_Query);

}

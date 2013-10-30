function Dots_and_Crits::Client_Unload(%this)
{

echo("Unloaded Client");

Dots_and_Crits.Game_Connection_Delete($GameConnection_Connection);

$GameConnection_Connection=0;

$GameConnection_Serverside_Connection=0;

}

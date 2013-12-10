function Module_Master_Server::Scene_Unload(%this)
{

$Bool_Is_Client=true;

$Bool_Is_Master_Server=false;

allowConnections(false);

Dots_and_Crits.Game_Connection_Delete($GameConnection_Connection);

Canvas.popDialog(Gui_Master_Server);

%this.Ass_Unload();

}

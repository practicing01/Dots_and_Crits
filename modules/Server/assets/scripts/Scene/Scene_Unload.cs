function Module_Server::Scene_Unload(%this)
{

$Bool_Is_Client=true;

allowConnections(false);

Dots_and_Crits.Game_Connection_Delete($GameConnection_Connection);

Canvas.popDialog(Gui_Server);

%this.Ass_Unload();

}

function Gui_Server_Menu::Play(%this)
{
echo($GameConnection_Serverside_Connection);//banana
if ($GameConnection_Serverside_Connection!=0)
{
echo("sent register play to server");//banana
commandToServer('Register_Play');

Module_Gui_Server_Menu.Scene_Unload();

}

}

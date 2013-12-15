function Gui_Server_Menu::Play(%this)
{

if ($GameConnection_Serverside_Connection!=0)
{

commandToServer('Register_Play');

Module_Gui_Server_Menu.Scene_Unload();

}

}

function Gui_Config_Menu::Set_Master_Server_IP(%this)
{

if ($platform$="Android")
{

toggleAndroidKeyboard(true);

}
else
{

$IP_Master_Server=Gui_Textedit_IP.getText();

echo("Set Master Server IP to" SPC $IP_Master_Server);

}

}
